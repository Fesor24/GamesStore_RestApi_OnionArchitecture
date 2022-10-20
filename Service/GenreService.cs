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
        public GenreService(IUnitofTest unitofTest, ILoggerManager logger)
        {
            _unitofTest = unitofTest;
            _logger = logger;
        }
    }
}
