using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
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
        private readonly Lazy<IAccountService> _accountService;
        private readonly IMapper _map;
        public ServiceManager(IUnitOfWork unit, ILoggerManager logger, IMapper map,
            UserManager<AppUser> user, IConfiguration config)
        {
            _gamesService = new Lazy<IGamesService>(() => new GamesService(unit, logger, map));
            _genreService = new Lazy<IGenreService>(() => new GenreService(unit, logger, map));
            _consoleDeviceService = new Lazy<IConsoleDeviceService>(() => new ConsoleDeviceService(unit, logger, map));
            _accountService = new Lazy<IAccountService>(() => new AccountService(logger, map, user, config));
            _map = map;
        }
        public IGamesService GamesService => _gamesService.Value;

        public IGenreService GenreService => _genreService.Value;

        public IConsoleDeviceService ConsoleDeviceService => _consoleDeviceService.Value;

        public IAccountService AccountService => _accountService.Value;
    }
}
