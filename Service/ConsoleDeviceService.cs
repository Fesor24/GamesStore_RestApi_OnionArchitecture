using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ConsoleDeviceService: IConsoleDeviceService
    {
        private readonly IUnitofTest _unitofTest;
        private readonly ILoggerManager _logger;
        public ConsoleDeviceService(IUnitofTest unitofTest, ILoggerManager logger)
        {
            _unitofTest = unitofTest;
            _logger = logger;
        }
    }
}
