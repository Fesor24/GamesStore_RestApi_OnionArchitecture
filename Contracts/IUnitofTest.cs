using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUnitofTest
    {
        IGamesRepository gamesRepository { get; }
        IGenreRepository genreRepository { get; }
        IConsoleDeviceRepository consoleDeviceRepository { get; }

        void Complete();
    }
}
