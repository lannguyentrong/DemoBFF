using DemoBFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBFF.Context
{
    public class DemoBFFContext: IDemoBFFContext
    {
        private List<Student> _students;
        public DemoBFFContext()
        {
            this._students = new List<Student>();
            this.Initialize();
        }

        public void Initialize()
        {
            this._students.Add(new Student
            {
                Id = 1,
                Name = "Student 1",
                Age = 10
            });
            this._students.Add(new Student
            {
                Id = 2,
                Name = "Student 2",
                Age = 11
            });
            this._students.Add(new Student
            {
                Id = 3,
                Name = "Student 3",
                Age = 12
            });
        }

        public List<Student> GetStudentSet()
        {
            return this._students;
        }
    }
}
