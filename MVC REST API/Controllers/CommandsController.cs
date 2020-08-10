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
        [HttpGet("{id}", Name = "GetCommandById")]
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


        //POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            //!AhmedShaban: Map the DTO to Command
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            //!AhmedShaban: Add the new command (object) in the context
            _repo.AddCommand(commandModel);
            //!AhmedShaban: Save the context to Database
            _repo.Save();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDto.Id},commandReadDto);
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommandById(int id)
        {
            var commandModelFromRepo = _repo.GetById(id);

            if (commandModelFromRepo != null)
            {
                _repo.DeleteCommand(commandModelFromRepo);
                _repo.Save();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
