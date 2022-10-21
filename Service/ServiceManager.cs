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
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IGamesService> _gamesService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IConsoleDeviceService> _consoleDeviceService;
        private readonly IMapper _map;
        public ServiceManager(IUnitofTest unitofTest, ILoggerManager logger, IMapper map)
        {
            _gamesService = new Lazy<IGamesService>(() => new GamesService(unitofTest, logger, map));
            _genreService = new Lazy<IGenreService>(() => new GenreService(unitofTest, logger, map));
            _consoleDeviceService = new Lazy<IConsoleDeviceService>(() => new ConsoleDeviceService(unitofTest, logger, map));
            _map = map;
        }
        public IGamesService GamesService => _gamesService.Value;

        public IGenreService GenreService => _genreService.Value;

        public IConsoleDeviceService ConsoleDeviceService => _consoleDeviceService.Value;
    }
}
