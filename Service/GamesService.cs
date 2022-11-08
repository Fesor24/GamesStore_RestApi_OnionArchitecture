﻿using AutoMapper;
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

namespace Service
{
    internal sealed class GamesService: IGamesService
    {
        private readonly IUnitofTest _unitofTest;
        private readonly ILoggerManager _logger;
        private readonly IMapper _map;

        public GamesService(IUnitofTest unitofTest, ILoggerManager logger, IMapper map)
        {
            _unitofTest = unitofTest;
            _logger = logger;
            _map = map;
        }

        public IEnumerable<GamesDto> GetAllGames(bool trackChanges)
        {
            try
            {
                var games =  _unitofTest.games.GetAllGames(trackChanges);
                return _map.Map<IEnumerable<GamesDto>>(games);
            }

            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllGames)} service method {ex}");
                throw;
            }
            
        }


        public GamesDto GetGameById(int id)
        {
            var game= _unitofTest.games.GetGameById(id);
            return _map.Map<GamesDto>(game);
        }
    }
}
