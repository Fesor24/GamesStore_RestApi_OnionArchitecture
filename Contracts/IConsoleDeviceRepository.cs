using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IConsoleDeviceRepository
    {
        Task<IEnumerable<ConsoleDevice>> GetAllDevice(bool trackChanges);
    }
}
