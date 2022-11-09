using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class GameNotFoundException: NotFoundException
    {
        public GameNotFoundException(int id) : base($"The game with id: {id} does not exist in the database")
        {

        }
    }
}
