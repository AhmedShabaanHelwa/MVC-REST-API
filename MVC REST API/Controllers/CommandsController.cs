using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC_REST_API.DTOs;
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
        //!AhmedShaban: Dependency Injection section
        private readonly ICommanderRepo _repo;
        private readonly IMapper _mapper;

        //private MockCommanderRepo _repo = new MockCommanderRepo();

        public CommandsController(ICommanderRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //GET api/Commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _repo.GetAll();
            return Ok(_mapper.Map< IEnumerable<CommandReadDto> >(commands));
            //Errors need to be handled
        }

        //GET api/Commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = _repo.GetById(id);

            if (null != command)
            {
                return Ok(_mapper.Map<CommandReadDto>(command));
            }
            else 
            {
                return NotFound();
            }
        }
    }
}
