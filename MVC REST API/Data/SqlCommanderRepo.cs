using S2E3.Data;
using S2E3.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_REST_API.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        //!AhmedShaban: DI of DataContext
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAll()
        {
            return _context.Commands.ToList();
        }

        public Command GetById(int id)
        {
            //!AhmedShaban: Use LINQ
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
