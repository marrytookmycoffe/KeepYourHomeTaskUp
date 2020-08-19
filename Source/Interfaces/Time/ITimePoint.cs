using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    interface ITimePoint : ITime
    {
        DateTime Start { get; set; }
    }
}