using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IGamesRepository> _gamesRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;
        private readonly Lazy<IConsoleDeviceRepository> _consoleDeviceRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            _gamesRepository = new Lazy<IGamesRepository>(() => new GamesRepository(context));
            _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(context));
            _consoleDeviceRepository = new Lazy<IConsoleDeviceRepository>(() => new ConsoleDeviceRepository(context));
        }
        public IGamesRepository games => _gamesRepository.Value;

        public IGenreRepository genre => _genreRepository.Value;

        public IConsoleDeviceRepository consoleDevice => _consoleDeviceRepository.Value;

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Complete() => await _context.SaveChangesAsync();
    
    }
}
