using S2E3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2E3.Data
{
    public interface ICommanderRepo
    {
        //Operation 0: Data persistence in Database
        public bool Save();
        //Operation 1: Get All Commands
        public IEnumerable<Command> GetAll();
        //Operation 2: Get a command by Id
        public Command GetById(int id);
        //Operation 3: Add a command
        public void AddCommand(Command command);
        //Operation 4:
        //Operation 5: Delete by Id
        public void DeleteCommand(Command command);
    }
}
