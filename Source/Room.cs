using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public class Room : ObjectIdentity
    {
        public Guid Building_Id { get; set; }
        public string RoomType { get; set; }
        public float Level { get; set; }
    }
}