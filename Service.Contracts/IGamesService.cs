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
        IEnumerable<GamesDto> GetAllGames(bool trackChanges);
        GamesDto GetGameById(int id, bool trackChanges);

        GamesDto CreateGame(GameForCreateDto game);

        void UpdateGame(int gameId, GameForUpdateDto gameForUpdateDto, bool trackChanges);

        void DeleteGame(int id, bool trackChanges);

        (GameForUpdateDto gameToPatch, Game gameEntity) GetGameForPatch(int gameId, bool trackChanges);

        void SaveChangesForPatch(GameForUpdateDto gameToPatch, Game game);

    }
}
