using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public class TimeRange : Time, ITimeRange
    {
        public DateTime End { get; set; }
    }
}