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
        public ServiceManager(IUnitofTest unitofTest, ILoggerManager logger)
        {
            _gamesService = new Lazy<IGamesService>(() => new GamesService(unitofTest, logger));
            _genreService = new Lazy<IGenreService>(() => new GenreService(unitofTest, logger));
            _consoleDeviceService = new Lazy<IConsoleDeviceService>(() => new ConsoleDeviceService(unitofTest, logger));
        }
        public IGamesService GamesService => _gamesService.Value;

        public IGenreService GenreService => _genreService.Value;

        public IConsoleDeviceService ConsoleDeviceService => _consoleDeviceService.Value;
    }
}
