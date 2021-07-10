using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared.Models
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
