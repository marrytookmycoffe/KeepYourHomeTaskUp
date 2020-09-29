using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTO
{
    public class TaskDTO
    {
        public TimeDTO Time { get; set; }
        public Guid Room_Id { get; set; }
        public Guid User_Id { get; set; }
    }
}
