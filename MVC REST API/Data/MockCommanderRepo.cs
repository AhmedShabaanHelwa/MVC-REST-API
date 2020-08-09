using S2E3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2E3.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAll()
        {
            List<Command> commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = " Boiler & Pan " },
                new Command { Id = 1, HowTo = "Cut the berd", Line = "Use a blade", Platform = " Meme the barber " },
                new Command { Id = 2, HowTo = "MAke a cup of tea", Line = "Place a teabag in a cup", Platform = " Boiler & cup " }
            };
            return commands;
        }

        public Command GetById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = " Boiler & Pan " };
        }
    }
}
