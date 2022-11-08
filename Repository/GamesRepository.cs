using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
            GetAll(trackChanges)
            .Include(x => x.Genre)
            .Include(x => x.ConsoleDevice)
            .OrderBy(c => c.Name)
            .ToList();
        

        public Game GetGameById(int id) =>

            throw new NotImplementedException();
            
    }
}
