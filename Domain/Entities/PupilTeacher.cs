using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiDomain.Entities
{
    public class PupilTeacher
    {
        public int PupilId { get; set; }
        public Pupil Pupil { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
