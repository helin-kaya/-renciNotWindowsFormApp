using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotUygulamasıEntityLayer.Entities
{
    [Table("LESSON")]
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public string LessonName { get; set; }
    }
}
