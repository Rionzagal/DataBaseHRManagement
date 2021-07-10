using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlamingSoftHR.Models
{
    public class LogTime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateLogged { get; set; }

        [Required, Range(0.0, 12.0, ErrorMessage = "Logged hours cannot exceed 12.0 hours per day.")]
        public double Hours { get; set; }

        [Required, ForeignKey("LogType")]
        public LogType ltype { get; set; }
        public int LogType { get; set; }

        [Required, ForeignKey("LoggedEmployee")]
        public Employee employee { get; set; }
        public int LoggedEmployee { get; set; }
    }
}
