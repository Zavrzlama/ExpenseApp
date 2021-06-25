using System;
using System.Collections.Generic;
using AutoMapper;
using ExpensesApp.API.Models;
using ExpensesApp.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExpensesApp.API.Controllers
{
    [ApiController]
    [Route("ExpensesApp/ClientRoles")]
    public class ClientRolesController : ControllerBase
    {
        private readonly ILogger<ClientRolesController> _logger;
        private readonly IClientRolesRepository _repository;
        private readonly IMapper _mapper;

        public ClientRolesController(ILogger<ClientRolesController> logger, IClientRolesRepository repository, IMapper mapper)
        {
            _logger = logger ?? throw  new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetRoles")]
        public IActionResult GetAllClientRoles()
        {
            var clientRolesRepository = _repository.GetRoles();

            return Ok(_mapper.Map<IEnumerable<ClientRoleDTO>>(clientRolesRepository));
        }

        [HttpGet("{id}", Name = "GetRole")]
        public IActionResult GetClientRoleById(int id)
        {
            if (!_repository.ClientRoleExists(id))
            {
                return NotFound();
            }
            var clientRole = _repository.GetClientRole(id);

            return Ok(_mapper.Map<ClientRoleDTO>(clientRole));
        }


        [HttpPost]
        public IActionResult PostClientRole(ClientRoleInsertDTO clientRolesInsertDTO)
        {
            var clientRoleEntity = _mapper.Map<Entities.ClientRole>(clientRolesInsertDTO);

            _repository.AddClientRole(clientRoleEntity);
            _repository.Save();

            var createdClientRole = _mapper.Map<ClientRoleDTO>(clientRoleEntity);

            return RedirectToRoute("GetRole", createdClientRole);
        }

        [HttpPut("{id}")]
        public IActionResult PutClientRole(int id, ClientRoleInsertDTO clientRolesInsertDTO)
        {
            if (!_repository.ClientRoleExists(id))
            {
                return NotFound();
            }

            var clientRoleEntity = _repository.GetClientRole(id);

            _mapper.Map(clientRolesInsertDTO,clientRoleEntity);

            _repository.Save();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PatchClientRole(int id, JsonPatchDocument<ClientRoleInsertDTO> jsonDoc)
        {

            var clientRoleEntity = _repository.GetClientRole(id);

            if (!_repository.ClientRoleExists(id))
            {
                return NotFound();
            }

            var roleForPatch = _mapper.Map<ClientRoleInsertDTO>(clientRoleEntity);

            jsonDoc.ApplyTo(roleForPatch,ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _mapper.Map(roleForPatch, clientRoleEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClientRole(int id)
        {
            if (!_repository.ClientRoleExists(id))
            {
                return NotFound();
            }

            var clientRole = _repository.GetClientRole(id);

            _repository.DeleteClientRole(clientRole);

            return NoContent();
        }

    }
}
