using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTO
{
public abstract class TimeDTO
    {
        public DateTime Start { get; set; }
        public DateTime RepatTime { get; set; }
    }
}