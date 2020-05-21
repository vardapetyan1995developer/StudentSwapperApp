using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSwapper.Models;

namespace StudentSwapper.Models
{
    public class GradeModel : BaseModel
    {
        public byte GradeNumber { get; set; }
        public string GradeName { get; set; }
    }
}
