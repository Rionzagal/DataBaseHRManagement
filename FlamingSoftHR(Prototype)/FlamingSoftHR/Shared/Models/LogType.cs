using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FlamingSoftHR.Shared.Models
{
    public class LogType
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(450)]
        public string Description { get; set; }

        public ICollection<LogTime> log { get; set; }
    }
}
