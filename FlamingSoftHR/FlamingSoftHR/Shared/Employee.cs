using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required, MaxLength(128)]
        public string FirstName { get; set; }

        [MaxLength(128)]
        public string MiddleName { get; set; }

        [Required, MaxLength(128)]
        public string LastName { get; set; }

        [Required, ForeignKey("Department")]
        public Department department { get; set; }
        public int Department { get; set; }

        [Required, ForeignKey("EmployeeType")]
        public EmployeeType EType { get; set; }
        public int EmployeeType { get; set; }
    }
}
