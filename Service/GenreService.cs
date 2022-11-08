using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class GenreService: IGenreService
    {
        private readonly IUnitOfWork _unitofTest;
        private readonly ILoggerManager _logger;
        private readonly IMapper _map;
        public GenreService(IUnitOfWork unitofTest, ILoggerManager logger, IMapper map)
        {
            _unitofTest = unitofTest;
            _logger = logger;
            _map = map;
        }

        public IEnumerable<GenreDto> GetAllGenres(bool trackChanges)
        {
            try
            {
                var allGenres = _unitofTest.genre.GetAllGenres(trackChanges);

                return _map.Map<IEnumerable<GenreDto>>(allGenres);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllGenres)} method {ex}");
                throw;
            }
        }
    }
}
