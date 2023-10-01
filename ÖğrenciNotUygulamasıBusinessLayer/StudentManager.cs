using Microsoft.EntityFrameworkCore;
using ÖğrenciNotUygulamasıDataLayer;
using ÖğrenciNotUygulamasıEntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ÖğrenciNotUygulamasıBusinessLayer
{
    public class StudentManager
    {
        MyContext context;

        public StudentManager()
        {
            context = context ?? new MyContext();
        }

        public bool AddStudent(Student s)
        {
            try
            {
                context.StudentTable.Add(s);
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Student> GetStudentsByNameSurname(string? name, string? surname)
        {
            try
            {
                return context.StudentTable.Where(x => x.Name.Contains(name) & x.Surname.Contains(surname)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
