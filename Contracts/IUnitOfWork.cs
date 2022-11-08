using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUnitOfWork
    {
        IGamesRepository games { get; }
        IGenreRepository genre { get; }
        IConsoleDeviceRepository consoleDevice { get; }

        void Complete();
    }
}
