using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Specification
{
    public class GamesWithGenreAndConsoleSpecification: BaseSpecification<Game>
    {
        public GamesWithGenreAndConsoleSpecification()
        {
            AddIncludes(x => x.Genre);
            AddIncludes(x => x.ConsoleDevice);
        }
    }
}
