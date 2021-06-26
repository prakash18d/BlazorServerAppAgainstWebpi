using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeClass
    {
        [Required]
        
       [Key]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }
        public string pojectName { get; set; }
    }
}
