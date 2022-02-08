using DemoBFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBFF.Context
{
    public interface IDemoBFFContext
    {
        public void Initialize();
        public List<Student> GetStudentSet();
    }
}
