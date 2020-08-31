using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source
{
    public class User : ObjectIdentity, IUser
    {
        /// <summary>
        /// sign of a user, uniq sign
        /// </summary>
        public string Mask { get; set; }
    }
}