using Infrastructure.DTO;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IBuildingServices
    {
        void Set(Guid userId, string name, string type);
        void Edit(Guid userId, string name);
    }
}