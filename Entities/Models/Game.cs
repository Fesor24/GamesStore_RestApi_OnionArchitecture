using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Game: BaseClass
    {
        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; } = String.Empty;
        [Required(ErrorMessage ="Description is a required field")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage ="Imageurl is a required field")]
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        
        public Decimal Price { get; set; }
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        [ForeignKey(nameof(ConsoleDevice))]
        public int ConsoleId { get; set; }
        public ConsoleDevice? ConsoleDevice { get; set; } 
    }
}
