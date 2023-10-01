using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ÖğrenciNotUygulamasıEntityLayer.Entities;

namespace ÖğrenciNotUygulamasıDataLayer
{
    public class MyContext:DbContext
    {
        public MyContext()
        {

        }
        public virtual DbSet<Lesson> LessonTable { get; set; }
        public virtual DbSet<Notlar> NotlarTable { get; set; }
        public virtual DbSet<Student> StudentTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("localConnection");
            optionsBuilder.UseSqlServer("Server=HELIN-PC\\SQLEXPRESS;Database=OgrenciNotUygulamasiDB;Trusted_Connection=True;TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
