using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    public class Students
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string StudentNAme { get; set; }
        public string gpa { get; set; }
    }
}
