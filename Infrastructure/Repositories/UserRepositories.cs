using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    interface UserRepositories
    {
        void CreatUser(string name);
        void GetUser(Guid id);
        void GetUser(string Mask);
        
    }
}
