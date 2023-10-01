using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÖğrenciNotUygulamasıDataLayer;
using ÖğrenciNotUygulamasıEntityLayer.Entities;

namespace ÖğrenciNotUygulamasıBusinessLayer
{
    
    public class NotlarManager

    {
        MyContext context;
        public NotlarManager()
        {
            context = context ?? new MyContext();
        }
        public bool AddNotlar(Notlar n)
        {
            try
            {
                context.NotlarTable.Add(n);
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
