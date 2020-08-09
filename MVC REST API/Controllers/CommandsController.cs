using Microsoft.AspNetCore.Mvc;
using S2E3.Data;
using S2E3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2E3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;

        //private MockCommanderRepo _repo = new MockCommanderRepo();

        public CommandsController(ICommanderRepo repo)
        {
            _repo = repo;
        }

        //GET api/Commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repo.GetAll();
            return Ok(commands);
            //Errors need to be handled
        }

        //GET api/Commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repo.GetById(id);

            return Ok(command);
        }
    }
}
