using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ConsoleDeviceService: IConsoleDeviceService
    {
        private readonly IUnitOfWork _unitofTest;
        private readonly ILoggerManager _logger;
        private readonly IMapper _map;
        public ConsoleDeviceService(IUnitOfWork unitofTest, ILoggerManager logger, IMapper map)
        {
            _unitofTest = unitofTest;
            _logger = logger;
            _map = map;
        }

        public async Task<IEnumerable<ConsoleDto>> GetAllDevice(bool trackChanges)
        {
            try
            {
                var allConsole = await _unitofTest.consoleDevice.GetAllDevice(trackChanges);
                return _map.Map<IEnumerable<ConsoleDto>>(allConsole);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllDevice)} method {ex}" );
                throw;
            }
        }
    }
}
