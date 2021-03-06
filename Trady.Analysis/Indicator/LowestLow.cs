﻿using System;
using System.Collections.Generic;
using System.Linq;
using Trady.Analysis.Infrastructure;
using Trady.Core;

namespace Trady.Analysis.Indicator
{
    public class LowestLow : Lowest<Candle, AnalyzableTick<decimal?>>
    {
        public LowestLow(IEnumerable<Candle> inputs, int periodCount)
            : base(inputs, i => i.Low, periodCount)
        {
        }
    }
}