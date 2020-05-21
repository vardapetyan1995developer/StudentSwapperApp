using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSwapper.Models;

namespace StudentSwapper.Models
{
    public partial class TeacherModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GradeModel Grade { get; set; }
    }

    public partial class TeacherModel : BaseModel
    {
        public List<StudentModel> Students { get; set; }

        public TeacherModel()
        {
            Students = new List<StudentModel>();
            Grade = new GradeModel();
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
