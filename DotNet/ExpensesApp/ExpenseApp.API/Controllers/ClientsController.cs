using System;
using System.Collections.Generic;
using AutoMapper;
using ExpensesApp.API.Models;
using ExpensesApp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesApp.API.Controllers
{
    [ApiController]
    [Route("ExpensesApp/Clients")]
    public class ClientsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _repository;

        public ClientsController(IMapper mapper, IClientRepository repository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            var clientsEntity = _repository.GetClinets();

            return Ok(_mapper.Map<IEnumerable<ClientDTO>>(clientsEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetClient(int id)
        {
            var clientEntity = _repository.GetClient(id);

            if (clientEntity == null)
                return NotFound();

            return Ok(_mapper.Map<ClientDTO>(clientEntity));
        }

    }
}
