using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ITaskRepositories
    {
        Source.Task GetTask(Guid id);
        IEnumerable<Source.Task> GetTasks();
        void Edit(Guid Id, DTO.TaskDataDTO dTO);
    }
}
