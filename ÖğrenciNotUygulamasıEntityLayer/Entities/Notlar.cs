using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciNotUygulamasıEntityLayer.Entities
{
    [Table("NOTLAR")]
    public class Notlar
    {
        [Key]
        public int Id { get; set; }
        public int DersNotu { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public virtual Lesson Lesson { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Student Student { get; set; }
    }
}
