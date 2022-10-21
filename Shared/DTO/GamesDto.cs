using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record GamesDto
    {
        public string name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public string ImageUrl { get; set; } = string.Empty;
        

        public Decimal Price { get; set; }
        
        public int GenreId { get; set; }
        public string Genre { get; set; } = String.Empty;
        public string ConsoleDevice { get; set; } = String.Empty;
    }
}
