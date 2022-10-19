using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ConsoleDevice: BaseClass
    {
        [Required(ErrorMessage="Console name is a required field")]
        public string Name { get; set; } = string.Empty;
        public ICollection<Games>? Games { get; set; }
    }
}
