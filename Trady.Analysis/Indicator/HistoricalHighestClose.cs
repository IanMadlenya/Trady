﻿using System;
using System.Collections.Generic;
using System.Linq;
using Trady.Analysis.Infrastructure;
using Trady.Core;

namespace Trady.Analysis.Indicator
{
    public class HistoricalHighestClose : HistoricalHighest<Candle, AnalyzableTick<decimal?>>
    {
        public HistoricalHighestClose(IEnumerable<Candle> inputs)
            : base(inputs, i => i.Close)
        {
        }
    }
}