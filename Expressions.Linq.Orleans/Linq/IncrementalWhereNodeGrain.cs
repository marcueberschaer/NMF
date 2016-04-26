﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NMF.Expressions.Linq.Orleans.Interfaces;
using NMF.Expressions.Linq.Orleans.Linq.Interfaces;
using Orleans;
using Orleans.Collections;
using Orleans.Streams;
using SL = System.Linq.Enumerable;

namespace NMF.Expressions.Linq.Orleans
{
    internal sealed class IncrementalWhereNodeGrain<TSource> : IncrementalNodeGrainBase<TSource, TSource>,
        IIncrementalWhereNodeGrain<TSource>
    {

        public Task SetObservingFunc(SerializableFunc<TSource, bool> observingFunc)
        {
            ResultEnumerable = InputList.Where(observingFunc.Value);
            AttachToResult();
            return TaskDone.Done;
        }
    }
}