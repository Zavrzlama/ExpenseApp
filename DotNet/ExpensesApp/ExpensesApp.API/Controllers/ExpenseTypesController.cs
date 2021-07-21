using System;
using System.Collections.Generic;
using AutoMapper;
using ExpensesApp.API.Models;
using ExpensesApp.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesApp.API.Controllers
{
    [ApiController]
    [Route("ExpensesApp/ExpenseTypes")]
    public class ExpenseTypesController : ControllerBase
    {
        private readonly IExpenseTypesRepository _expenseTypesRepository;
        private readonly IMapper _mapper;

        public ExpenseTypesController(IExpenseTypesRepository expenseTypesRepository, IMapper mapper)
        {
            _expenseTypesRepository =
                expenseTypesRepository ?? throw new ArgumentNullException(nameof(expenseTypesRepository));

            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetExpenseTypes()
        {
            var expenseTypesEntity = _expenseTypesRepository.GetExpenseTypes();

            return Ok(_mapper.Map<IEnumerable<ExpenseTypeDTO>>(expenseTypesEntity));
        }

        [HttpGet("{id}", Name = "GetExpenseType")]
        public IActionResult GetExpenseTypeById(int id)
        {
            var expenseTypeEntity = _expenseTypesRepository.GetExpenseType(id);

            if (expenseTypeEntity == null)
                return NotFound();

            return Ok(_mapper.Map<ExpenseTypeDTO>(expenseTypeEntity));
        }

        [HttpPost]
        public IActionResult AddExpenseType(ExpenseTypeInsertDTO expenseTypeInsertDto)
        {
            var expenseTypeEntity = _mapper.Map<Entities.ExpenseType>(expenseTypeInsertDto);

            _expenseTypesRepository.AddExpenseType(expenseTypeEntity);
            _expenseTypesRepository.Save();

            var createdExpenseType = _mapper.Map<ExpenseTypeDTO>(expenseTypeEntity);

            return RedirectToRoute("GetExpenseType", createdExpenseType);
        }

        [HttpPut("{id}")]
        public IActionResult PutExpenseType(int id,ExpenseTypeInsertDTO expenseTypeInsertDto)
        {
            var expenseTypeEntity = _expenseTypesRepository.GetExpenseType(id);

            if (expenseTypeEntity == null)
                return NotFound();

            _mapper.Map(expenseTypeInsertDto, expenseTypeEntity);

            _expenseTypesRepository.Save();

            return NoContent();
        }

        [HttpPatch("id")]
        public IActionResult PatchExpenseType(int id, JsonPatchDocument<ExpenseTypeInsertDTO> jsonDoc)
        {
            return NoContent();
        }
    }
}