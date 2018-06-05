using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGroups
{
    public static class StudentExtension
    {
        public static IEnumerable<Students> byGroup(this List<Students> allStudents, int desiredGroup)
        {
            var selectedByGroup =
                from stud in allStudents
                where stud.groups == 2
                orderby stud.firstName
                select stud;

            return selectedByGroup;
        }
        public static string showList(this List<double> doubleList)
        {
            string combined = "";
            foreach (var item in doubleList)
            {
                combined += item + " ";
            }
            return combined;
        }
        public static List<string> joinQuary(this List<string> current)
        {
            var separatedbyGroup =
                from stgroup in Group.groupAll
                join studs in Students.All on stgroup.GroupNumber equals studs.groups into combinedStudents
                select new { DepName = stgroup.DepartmentName, GroupNum = stgroup.GroupNumber, Students = combinedStudents };

            List<string> result = new List<string>();
            foreach (var item in separatedbyGroup)
            {
                result.Add(string.Format("Group {0} Students", item.GroupNum));
                foreach (var stud in item.Students)
                {
                    result.Add(string.Format("   {0} {1} {2}", stud.firstName, stud.lastName, stud.groups));
                }
            }
            return result;
        }
    }
}
