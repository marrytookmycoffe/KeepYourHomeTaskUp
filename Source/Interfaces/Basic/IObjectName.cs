using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public interface IObjectIdentity
    {
        string Name { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}