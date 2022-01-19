using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Village_Program.Models
{
    public class Citizen
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public bool IsBornInVillage { get; set; }
        public DateTime BirthDate { get; set; }
    }
}