using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
public abstract class ObjectId :IId
    {
        public Guid Id { get; set; }
    }
}