using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTO
{
    public abstract record GameForManipulationDto
    {
        [Required(ErrorMessage = "Name is a required field")]
        public string name { get; init; } = String.Empty;
        [Required(ErrorMessage = "Description is a required field")]
        public string description { get; init; } = String.Empty;
        [Required(ErrorMessage = "Price is a required field")]
        [Range(1.0, int.MaxValue, ErrorMessage = "Price can not be less than 1")]
        public decimal price { get; init; }
        [Required(ErrorMessage = "Include a genre id for this game")]
        public int genreId { get; init; }
        [Required(ErrorMessage = "Include a console id for this game")]
        public int consoleId { get; init; }
    }
}
