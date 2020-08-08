using S2E3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2E3.Data
{
    public interface ICommanderRepo
    {
        //Operation 1: Get All Commands
        public IEnumerable<Command> GetAppCommands();
        //Operation 2: Get a command by Id
        public Command GetCommandById(int id);
    }
}
