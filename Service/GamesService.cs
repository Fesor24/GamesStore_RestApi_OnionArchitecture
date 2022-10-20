using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class GamesService: IGamesService
    {
        private readonly IUnitofTest _unitofTest;
        private readonly ILoggerManager _logger;

        public GamesService(IUnitofTest unitofTest, ILoggerManager logger)
        {
            _unitofTest = unitofTest;
            _logger = _logger;
        }
    }
}
