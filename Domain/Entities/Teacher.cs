using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiDomain.Entities
{
    public  class Teacher
    {
        public int Id { get; set; }
        public string  Name { get; set; }   
        public string LastName { get; set; }
        public int  Gender { get; set; }
        public string  subject { get;set; }
        public List<PupilTeacher> PupilTeachers { get; set; }
    }
}
