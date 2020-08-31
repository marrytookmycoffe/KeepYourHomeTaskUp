using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public class Task: ObjectIdentity
    {
        public Time Time { get; set; }
        public Guid Room_Id { get; set; }
        public Guid User_Id { get; set; }
    }
}
