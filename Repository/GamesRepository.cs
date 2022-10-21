using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GamesRepository: GenericRepository<Game>, IGamesRepository
    {
        public GamesRepository(AppDbContext context): base(context)
        {

        }

        public IEnumerable<Game> GetAllGames(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(p => p.Name)
            .ToList();
    }
}
