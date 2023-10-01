using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÖğrenciNotUygulamasıDataLayer;
using ÖğrenciNotUygulamasıEntityLayer.Entities;

namespace ÖğrenciNotUygulamasıBusinessLayer
{
    public class LessonManager
    {
        MyContext context;

        public LessonManager()
        {
            context = context ?? new MyContext();
        }

        public bool AddLesson(Lesson l)
        {
            try
            {
                context.LessonTable.Add(l);
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Lesson> GetLessonsByName(string? name)
        {
            try
            {
                return context.LessonTable.Where(x => x.LessonName.Contains(name)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
