using DemoBFF.Models;
using DemoBFF.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebBFFController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public WebBFFController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        // GET: api/<MobileBFFController>
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = this._studentRepository.GetAll();
            return Ok(result);
        }

        // GET api/<MobileBFFController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student student = this._studentRepository.GetById(id);
            return Ok(student);
        }
    }
}
