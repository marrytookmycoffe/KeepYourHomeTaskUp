using Infrastructure.DTO;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface ITaskServices
    {
        void Add(Source.Task task);
        void Edit(Guid id, TaskDataDTO taskData);
        void Delate(Guid id);
    }
}