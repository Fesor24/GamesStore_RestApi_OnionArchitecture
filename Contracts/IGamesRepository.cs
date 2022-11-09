using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGamesRepository
    {
        Task<PagedList<Game>>GetAllGames(bool trackChanges, GameParameters gameParameters);
        Task<Game> GetGameById(int id, bool trackChanges);

        void CreateGame(Game game);

        void DeleteGame(Game game);

       
    }
}
