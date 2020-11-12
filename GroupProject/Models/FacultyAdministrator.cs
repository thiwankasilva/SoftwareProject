using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class FacultyAdministrator
    {
        [Key]
        public String AdminId { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public int ContactNumber { get; set; }
    }
}
