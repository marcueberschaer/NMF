﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SL = System.Linq.Enumerable;
using NMF.Expressions.Linq;

namespace NMF.Expressions
{
    internal class SelectExpression<TSource, TResult> : IEnumerableExpression<TResult>, IOptimizableEnumerableExpression
    {
        public IEnumerableExpression<TSource> Source { get; private set; }
        public Expression<Func<TSource, TResult>> SelectorExpression { get; private set; }
        public Func<TSource, TResult> SelectorCompiled { get; private set; }

        private INotifyEnumerable<TResult> notifyEnumerable;
        public Expression OptSelectorExpression => SelectorExpression;

        public SelectExpression(IEnumerableExpression<TSource> source, Expression<Func<TSource, TResult>> selector, Func<TSource, TResult> selectorCompiled)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (selectorCompiled == null) selectorCompiled = ExpressionCompileRewriter.Compile(selector);

            Source = source;
            SelectorExpression = selector;
            SelectorCompiled = selectorCompiled;
#if DEBUG
            QueryExpressionDgmlVisualizer.AddNode(this);
#endif
        }

        public INotifyEnumerable<TResult> AsNotifiable()
        {
            IEnumerableExpression<TResult> optimizedExpression = AsOptimized<TResult>();

            if (optimizedExpression != this)
                return optimizedExpression.AsNotifiable();

            if (notifyEnumerable == null)
            {
                notifyEnumerable = Source.AsNotifiable().Select(SelectorExpression);
            }
            return notifyEnumerable;
        }

        public IEnumerator<TResult> GetEnumerator()
        {
            if (notifyEnumerable != null) return notifyEnumerable.GetEnumerator();
            return SL.Select(Source, SelectorCompiled).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return AsNotifiable();
        }

        public IEnumerableExpression<TOptimizedResult> AsOptimized<TOptimizedResult>(IOptimizableEnumerableExpression prevOptExpression = null)
        {
#if DEBUG
            VisitForDebugging(SelectorExpression);
#endif

            if (this.IsSourceOptimizable(Source))
                return this.Optimize<TResult>(Source as IOptimizableEnumerableExpression).AsOptimized<TOptimizedResult>(prevOptExpression);

            if(prevOptExpression != null)
                return Merge<TOptimizedResult>(prevOptExpression);

            return (IEnumerableExpression<TOptimizedResult>) this;
        }

        public IEnumerableExpression<TOptimizedResult> Merge<TOptimizedResult>(IOptimizableEnumerableExpression prevOptExpression)
        {
            var mergedSelectorExpression = QueryOptimizer.Optimize<TSource, TResult, TOptimizedResult>(prevOptExpression.OptSelectorExpression, OptSelectorExpression) as Expression<Func<TSource, TOptimizedResult>>;
            return new SelectExpression<TSource, TOptimizedResult>(Source, mergedSelectorExpression, null);
        }

        private void VisitForDebugging(Expression expression)
        {
            //Ausgabe überprüfen
            DebugVisitor debugVisitor = new DebugVisitor();
            debugVisitor.Visit(expression);
        }
    }
}
