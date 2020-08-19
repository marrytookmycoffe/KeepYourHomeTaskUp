using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
public interface IObjectName
    {
        string Name { get; set; }
        string Title { get; set; }
        //RegionInfo UserRegion { get; set; }
    }
}