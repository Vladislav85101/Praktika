using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examin
{
    class Mass
    {
        public string Name;
        public string Owner;
        public int Page;

        public Mass(string Name, string Owner, int Page)
        {
            this.Name = Name;
            this.Owner = Owner;
            this.Page = Page;
        }

    }
}
