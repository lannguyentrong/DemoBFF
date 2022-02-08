using DemoBFF.Models;
using DemoBFF.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoBFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileBFFController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public MobileBFFController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        // GET: api/<MobileBFFController>
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = from item in this._studentRepository.GetAll()
                         select new
                         {
                             Id = item.Id,
                             Name = item.Name
                         };
            return Ok(result);
        }

        // GET api/<MobileBFFController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student student = this._studentRepository.GetById(id);
            return Ok(new {
                Id = student.Id,
                Name = student.Name
            });
        }
    }
}
