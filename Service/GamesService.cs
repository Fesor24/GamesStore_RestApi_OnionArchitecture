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

        public GamesDto CreateGame(GameForCreateDto game)
        {
            var gameEntity = _map.Map<Game>(game);

            _unit.games.CreateGame(gameEntity);
            _unit.Complete();

            var gameToReturn = _map.Map<GamesDto>(gameEntity);
            return gameToReturn;

        }

        public void DeleteGame(int id, bool trackChanges)
        {
            var game = _unit.games.GetGameById(id, trackChanges);

            if (game == null) throw new GameNotFoundException(id);

            _unit.games.DeleteGame(game);
            _unit.Complete();
        }

        public IEnumerable<GamesDto> GetAllGames(bool trackChanges)
        {
            try
            {
                var games =  _unit.games.GetAllGames(trackChanges);
                return _map.Map<IEnumerable<GamesDto>>(games);
            }

            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllGames)} service method {ex}");
                throw;
            }
            
        }


        public GamesDto GetGameById(int id, bool trackChanges)
        {
            try
            {
                var game = _unit.games.GetGameById(id, trackChanges);
                if (game == null) throw new GameNotFoundException(id);

                return _map.Map<GamesDto>(game);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetGameById)} service method {ex}");
                throw;
            }
            
        }
    }
}
