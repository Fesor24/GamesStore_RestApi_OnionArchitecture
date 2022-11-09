using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Specification;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
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
        

        public async Task<PagedList<Game>> GetAllGames(bool trackChanges, GameParameters gameParameters)
        {
            var games = await GetAll(trackChanges)
                            .Include(x => x.Genre)
                            .Include(x => x.ConsoleDevice)
                            .OrderBy(c => c.Id)
                            .ToListAsync();

     

            return PagedList<Game>
                .ToPagedList(games, gameParameters.pageNumber, gameParameters.PageSize);
        }
           

        


        public async Task<Game> GetGameById(int id, bool trackChanges) =>

            await GetByCondition(x => x.Id == id, trackChanges)
            .Include(x => x.Genre)
            .Include(x => x.ConsoleDevice)
            .OrderBy(x => x.Name)
            .FirstOrDefaultAsync();
            
    }
}
