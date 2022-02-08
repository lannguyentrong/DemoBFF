using DemoBFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBFF.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
        public Student GetById(int id);
    }
}
