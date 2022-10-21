using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class GenreService: IGenreService
    {
        private readonly IUnitofTest _unitofTest;
        private readonly ILoggerManager _logger;
        private readonly IMapper _map;
        public GenreService(IUnitofTest unitofTest, ILoggerManager logger, IMapper map)
        {
            _unitofTest = unitofTest;
            _logger = logger;
            _map = map;
        }
    }
}
