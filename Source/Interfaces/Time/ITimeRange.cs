using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    interface ITimeRange : ITimePoint
    {
        DateTime End { get; set; }
    }
}