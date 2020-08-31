using Infrastructure.DTO;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IRoomServices
    {
        void Add(Room room);
        void Edit(Guid id, string name, string description, string type);
        void Delete(Guid id);
    }
}