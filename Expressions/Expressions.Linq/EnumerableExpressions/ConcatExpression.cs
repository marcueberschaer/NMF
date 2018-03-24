﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SL = System.Linq.Enumerable;
using NMF.Expressions.Linq;

namespace NMF.Expressions
{
    internal class ConcatExpression<T> : IEnumerableExpression<T>, ISQO
    {
        public IEnumerableExpression<T> Source { get; private set; }
        public IEnumerable<T> Other { get; private set; }
        private INotifyEnumerable<T> notifyEnumerable;

        public IEnumerableExpression OptSource => Source;

        public ConcatExpression(IEnumerableExpression<T> source, IEnumerable<T> other)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (other == null) throw new ArgumentNullException("other");

            Source = source;
            Other = other;
        }

        public INotifyEnumerable<T> AsNotifiable()
        {
            if (notifyEnumerable == null)
            {
                var otherExpression = Other as IEnumerableExpression<T>;
                IEnumerable<T> other = Other;
                if (otherExpression != null)
                {
                    other = otherExpression.AsNotifiable();
                }
                notifyEnumerable = Source.AsNotifiable().Concat(other);
            }
            return notifyEnumerable;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (notifyEnumerable != null) return notifyEnumerable.GetEnumerator();
            return SL.Concat(Source, Other).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return AsNotifiable();
        }
    }
}
