using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Result
    {
        [Key]
        public string StudentId { get; set; }
        public string Exam { get; set; }
        public string Grade { get; set; }
        public int ModuleName { get; set; }
    }
}
