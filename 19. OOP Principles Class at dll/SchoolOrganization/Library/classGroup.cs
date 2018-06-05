using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class classGroup : Comments
    {
        public string identifier { get; set; }

        public List<Teacher> setofTeachers = new List<Teacher>();
    }
}
