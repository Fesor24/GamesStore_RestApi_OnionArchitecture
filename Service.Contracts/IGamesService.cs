using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;
using Entities.Models;

namespace Service.Contracts
{
    public interface IGamesService
    {
        Task<IEnumerable<GamesDto>> GetAllGames(bool trackChanges);
        Task<GamesDto> GetGameById(int id, bool trackChanges);

        Task<GamesDto> CreateGame(GameForCreateDto game);

        Task UpdateGame(int gameId, GameForUpdateDto gameForUpdateDto, bool trackChanges);

        Task DeleteGame(int id, bool trackChanges);

        Task<(GameForUpdateDto gameToPatch, Game gameEntity)> GetGameForPatch(int gameId, bool trackChanges);

        Task SaveChangesForPatch(GameForUpdateDto gameToPatch, Game game);

    }
}
