﻿using System;
using System.Collections.Generic;
using System.Linq;
using Trady.Analysis.Infrastructure;
using Trady.Core;

namespace Trady.Analysis.Indicator
{
    public class SimpleMovingAverage<TInput, TOutput> : NumericAnalyzableBase<TInput, decimal?, TOutput>
    {
        public int PeriodCount { get; }

        public SimpleMovingAverage(IEnumerable<TInput> inputs, Func<TInput, decimal?> inputMapper, int periodCount)
            : base(inputs, inputMapper)
        {
            PeriodCount = periodCount;
        }

        protected override decimal? ComputeByIndexImpl(IReadOnlyList<decimal?> mappedInputs, int index)
            => index >= PeriodCount - 1 ? mappedInputs.Skip(index - PeriodCount + 1).Take(PeriodCount).Average() : null;
    }

    public class SimpleMovingAverageByTuple : SimpleMovingAverage<decimal?, decimal?>
    {
        public SimpleMovingAverageByTuple(IEnumerable<decimal?> values, int periodCount)
            : base(values, c => c, periodCount) { }

		public SimpleMovingAverageByTuple(IEnumerable<decimal> values, int periodCount)
	        : this(values.Cast<decimal?>(), periodCount) { }
    }

    public class SimpleMovingAverage : SimpleMovingAverage<Candle, AnalyzableTick<decimal?>>
    {
        public SimpleMovingAverage(IEnumerable<Candle> inputs, int periodCount)
            : base(inputs, i => i.Close, periodCount) { }
    }
}