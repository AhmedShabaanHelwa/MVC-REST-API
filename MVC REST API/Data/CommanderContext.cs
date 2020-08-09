using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using S2E3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_REST_API.Data
{
    public class CommanderContext : DbContext
    {
        //!AhmedShaban: 1 - Passing options to DbContext base class
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        //!AhmedShaban: 2 - Creat tables of the DataBase
        public DbSet<Command> Commands { set; get; }
    }
}
