using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Student
    {
        [Key]
        public String StudentId { get; set; }
        public String Name { get; set; }
        public String StudentMail { get; set; }
        public String Gender { get; set; }
        public int ContactNumber { get; set; }
        public String Dob { get; set; }


    }
}
