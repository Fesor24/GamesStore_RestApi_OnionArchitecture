using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
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
            IQueryable<Game> query;

            if(string.IsNullOrEmpty(gameParameters.console) && string.IsNullOrEmpty(gameParameters.genre))
            {
                query = GetAll(trackChanges);
            }

            else
            {
                if (!string.IsNullOrEmpty(gameParameters.console) && !string.IsNullOrEmpty(gameParameters.genre))
                {
                    query = GetByCondition(x => x.Genre.Name.ToLower() == gameParameters.genre.ToLower()
                                && x.ConsoleDevice.Name.ToLower() == gameParameters.console.ToLower(),
                                trackChanges);

                }

                else if (string.IsNullOrEmpty(gameParameters.console) && !string.IsNullOrEmpty(gameParameters.genre))
                {
                    query = GetByCondition(x => x.Genre.Name.ToLower() == gameParameters.genre.ToLower(),

                            trackChanges);
                }

                else
                {
                    query = GetByCondition(x => x.ConsoleDevice.Name == gameParameters.console.ToLower(),

                            trackChanges);
                }

                
            }


            var games =  await query
                            .Include(x => x.Genre)
                            .Include(x => x.ConsoleDevice)
                            .Search(gameParameters.searchName)
                            .Sort(gameParameters.OrderBy)
                            .ToListAsync();



            return PagedList<Game>
                .ToPagedList(games, gameParameters.pageNumber, gameParameters.PageSize);
        }
           

        


        public async Task<Game> GetGameById(int id, bool trackChanges) =>

            await GetByCondition(x => x.Id == id, trackChanges)
            .Include(x => x.Genre)
            .Include(x => x.ConsoleDevice)
            .FirstOrDefaultAsync();

  
    }
}
