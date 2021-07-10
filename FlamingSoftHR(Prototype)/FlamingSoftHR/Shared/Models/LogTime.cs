using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Shared.Models
{
    public class LogTime
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime DateLogged { get; set; }

        [Required, Range(0, 12.0, ErrorMessage = "Value for this field must not be greater than 12.0!")]
        public double Hours { get; set; }

        [Required, ForeignKey("LogType")]
        public int LogtypeId { get; set; }
        public LogType LogType { get; set; }

        [Required, ForeignKey("LoggedEmployee")]
        public int LoggedEmployee { get; set; }
        public Employees Employees { get; set; }
    }
}
