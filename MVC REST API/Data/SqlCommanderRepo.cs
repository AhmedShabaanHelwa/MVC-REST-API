using S2E3.Data;
using S2E3.Models;
using System;
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

        public void AddCommand(Command command)
        {
            if (null == command)
                throw new ArgumentNullException(nameof(command));

            _context.Add(command);
        }

        public void DeleteCommand(Command command)
        {
            if (null == command)
            {
                throw new NotImplementedException(nameof(command));
            }
            else
            {
                _context.Commands.Remove(command);
            }
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

        public bool Save()
        {
            _context.SaveChanges();
            return true;
        }
    }
}
