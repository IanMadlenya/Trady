﻿using System;
using Trady.Core;

namespace Trady.Analysis.Pattern.Candle
{
    /// <summary>
    /// Reference: http://stockcharts.com/school/doku.php?id=chart_school:chart_analysis:candlestick_pattern_dictionary
    /// </summary>
    public class SpinningTop : PatternBase<IsMatchedResult>
    {
        public SpinningTop(Equity equity) : base(equity)
        {
        }

        protected override TickBase ComputeResultByIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}