using DemoBFF.Context;
using DemoBFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBFF.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDemoBFFContext _context;
        
        public StudentRepository(IDemoBFFContext context)
        {
            this._context = context;
        }

        public List<Student> GetAll()
        {
            return this._context.GetStudentSet();
        }

        public Student GetById(int id)
        {
            return (from item in this._context.GetStudentSet()
                    where item.Id == id
                    select item).FirstOrDefault();
        }
    }
}
