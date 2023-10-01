using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotUygulamasıEntityLayer.Entities
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim min 2 mak 50 karakter olmalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim min 2 mak 50 karakter olmalıdır")]
        public string Surname { get; set; }

        public int Sinif { get; set; }
    }
}
