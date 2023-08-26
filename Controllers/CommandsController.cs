using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Commander.Controllers 

{
    [Route("api/commands")] // how to get to API endpoints within the controller, hardcoded so it won't change 
    // route will be api/commands
    [ApiController] // easier to get the default behaviors 
   public class CommandsController : ControllerBase // inherits from base class controller base
    { // want to create endpoints so implementing as action results in the api controller 
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        // URI may be the same, but the verb they respond to changes their action  

        // responds to GET api/commands

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> getAllCommands()
        {
            var commandItems = _repository.GetAllCommands();// holds results

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
  
  
  
  
  
        [HttpGet("{id}", Name="GetCommandById")] // gives us route to GET action result GETapi/commands/{id}
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();

        }

        //GET api/commands
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        { // puts result of api request body into command model to put into repository 
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repository.CreateCommand(commandModel); 
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel); // maps command to commandReadDto

            return CreatedAtRoute(nameof(GetCommandById),new {Id = commandReadDto.Id}, commandReadDto);
            // returns location for headers in postman and the new status of 201 created 

            // so to change the URI and the response to 201 instaed of 200
            //return Ok(commandReadDto);
        }

        // PUT api/command/{id} 
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if (commandModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(commandUpdateDto, commandModelFromRepo);

            _repository.UpdateCommand(commandModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        // for patch action result 

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDoc)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }

            var commandToPatch = _mapper.Map<CommandUpdateDto>(commandModelFromRepo);

            patchDoc.ApplyTo(commandToPatch, ModelState);

            if(!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(commandToPatch, commandModelFromRepo); // since commandToPatch has been validated, we can map 
            // to the model from rep o

            _repository.UpdateCommand(commandModelFromRepo);

            _repository.SaveChanges();

            return NoContent();



        }
        // DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if (commandModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCommand(commandModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }
    }
}
