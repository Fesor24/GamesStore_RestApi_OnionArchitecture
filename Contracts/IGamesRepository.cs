using Entities.Models;
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
        Task<IEnumerable<Game> >GetAllGames(bool trackChanges);
        Task<Game> GetGameById(int id, bool trackChanges);

        void CreateGame(Game game);

        void DeleteGame(Game game);

       
    }
}
