using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared.Models
{
    public class EmployeeType
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string Description { get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
