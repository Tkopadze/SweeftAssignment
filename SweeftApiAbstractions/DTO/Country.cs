using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiAbstractions.DTO
{
    public class Country
    {
        public string region { get; set; }
        public string subregion { get; set; }
        public int population { get; set; }
        public Name name { get; set; }
       
    }


    public class Name
    {
        public string common { get; set; }
    }


}
