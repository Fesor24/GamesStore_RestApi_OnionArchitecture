using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IGamesService GamesService { get; }
        IGenreService GenreService { get; }
        IConsoleDeviceService ConsoleDeviceService { get; }
        IAccountService AccountService { get; }
    }
}
