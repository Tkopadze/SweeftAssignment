﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiDomain.Entities
{
    public  class Pupil
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }    
        public int  Gender { get; set; }  // 1 male 2 female 
        public int Grade { get; set; }
        public List<PupilTeacher> PupilTeachers { get; set; }
    }
}
