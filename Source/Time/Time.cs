using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public abstract class Time : ITime
    {
        public DateTime Start { get; set; }
        public DateTime RepatTime { get; set; }
    }
}