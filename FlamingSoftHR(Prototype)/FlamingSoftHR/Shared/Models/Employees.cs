using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared.Models
{
    public class Employees
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [Required, MaxLength(128)]
        public string FirstName { get; set; }

        [MaxLength(128)]
        public string MiddleName { get; set; }

        [Required, MaxLength(128)]
        public string LastName { get; set; }

        [Required, ForeignKey("Department")]
        public int Department { get; set; }
        public Department DepartmentId { get; set; }

        [Required, ForeignKey("EmployeeType")]
        public int EmployeeType { get; set; }
        public EmployeeType Type { get; set; }

        public ICollection<LogTime> LogTime { get; set; }
    }
}
