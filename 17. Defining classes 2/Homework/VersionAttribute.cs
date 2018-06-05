using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface)]
    public class VersionAttribute : Attribute
    {
        public int mj { get; set; }
        public int mn { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.mj = major;
            this.mn = minor;
        }
        public override string ToString()
        {
            return string.Format("{0}.{1}", this.mj, this.mn);
        }
    }
}
