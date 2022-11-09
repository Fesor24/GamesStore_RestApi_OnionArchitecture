using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Exceptions;
using Shared.RequestFeatures;

namespace Service
{
    internal sealed class GamesService: IGamesService
    {
        private readonly IUnitOfWork _unit;
        private readonly ILoggerManager _logger;
        private readonly IMapper _map;

        public GamesService(IUnitOfWork unit, ILoggerManager logger, IMapper map)
        {
            _unit = unit;
            _logger = logger;
            _map = map;
        }

        public async Task<GamesDto> CreateGame(GameForCreateDto game)
        {
            var gameEntity = _map.Map<Game>(game);

            _unit.games.CreateGame(gameEntity);
            await _unit.Complete();

            var gameToReturn = _map.Map<GamesDto>(gameEntity);
            return gameToReturn;

        }

        public async Task DeleteGame(int id, bool trackChanges)
        {
            var game = await _unit.games.GetGameById(id, trackChanges);

            if (game == null) throw new GameNotFoundException(id);

            _unit.games.DeleteGame(game);
            await _unit.Complete();
        }

        public async Task<(IEnumerable<GamesDto> games, MetaData metaData)> GetAllGames(bool trackChanges, GameParameters gameParameters)
        {
            try
            {
                var gamesWithMetaData =  await _unit.games.GetAllGames(trackChanges, gameParameters);
                var gamesDto = _map.Map<IEnumerable<GamesDto>>(gamesWithMetaData);

                return (games: gamesDto, metaData: gamesWithMetaData.metaData);
            }

            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllGames)} service method {ex}");
                throw;
            }
            
        }


        public async Task<GamesDto> GetGameById(int id, bool trackChanges)
        {
            try
            {
                var game = await _unit.games.GetGameById(id, trackChanges);
                if (game == null) throw new GameNotFoundException(id);

                return _map.Map<GamesDto>(game);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetGameById)} service method {ex}");
                throw;
            }
            
        }

        public async Task<(GameForUpdateDto gameToPatch, Game gameEntity)> GetGameForPatch(int gameId, bool trackChanges)
        {
            var gameEntity = await _unit.games.GetGameById(gameId, trackChanges);

            if (gameEntity == null) throw new GameNotFoundException(gameId);

            var gameToPatch = _map.Map<GameForUpdateDto>(gameEntity);

            return (gameToPatch, gameEntity);
        }

        public async Task SaveChangesForPatch(GameForUpdateDto gameToPatch, Game gameEntity)
        {
            _map.Map(gameToPatch, gameEntity);
            await _unit.Complete();
        }

        public async Task UpdateGame(int gameId, GameForUpdateDto gameForUpdateDto, bool trackChanges)
        {
            var game = await _unit.games.GetGameById(gameId, trackChanges);

            if (game == null) throw new GameNotFoundException(gameId);

            _map.Map(gameForUpdateDto, game);

            await _unit.Complete();


        }
    }
}
