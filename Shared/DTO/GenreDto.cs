using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record GenreDto
    {
        public string name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
