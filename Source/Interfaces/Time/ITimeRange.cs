using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    interface ITimeRange : ITime
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }
    }
}