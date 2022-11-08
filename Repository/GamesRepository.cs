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

        public void CreateGame(Game game) => Create(game);

        public void DeleteGame(Game game) => Delete(game);
        

        public IEnumerable<Game> GetAllGames(bool trackChanges) =>
            GetAll(trackChanges)
            .Include(x => x.Genre)
            .Include(x => x.ConsoleDevice)
            .OrderBy(c => c.Name)
            .ToList();


        public Game GetGameById(int id, bool trackChanges) =>

            GetByCondition(x => x.Id == id, trackChanges)
            .Include(x => x.Genre)
            .Include(x => x.ConsoleDevice)
            .OrderBy(x => x.Name)
            .FirstOrDefault();
            
    }
}
