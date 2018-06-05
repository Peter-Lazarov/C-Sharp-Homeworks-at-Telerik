using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGroups
{
    public class Group
    {
        public int GroupNumber { get; set;}
        public string DepartmentName { get; set; }

        public static List<Group> groupAll = new List<Group>();
        public Group()
        {
            groupAll.Add(this);
        }
        public Group(int groupnum, string depName)
        {
            this.GroupNumber = groupnum;
            this.DepartmentName = depName;
            groupAll.Add(this);
        }
    }
}
