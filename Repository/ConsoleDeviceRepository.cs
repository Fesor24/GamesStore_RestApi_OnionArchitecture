using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ConsoleDeviceRepository: GenericRepository<ConsoleDevice>, IConsoleDeviceRepository
    {
        public ConsoleDeviceRepository(AppDbContext context): base(context)
        {

        }

        public IEnumerable<ConsoleDevice> GetAllDevice(bool trackChanges) =>
            GetAll(trackChanges)
            .OrderBy(x => x.Name)
            .ToList();
            

    }
}
