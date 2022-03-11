using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookStock
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int InStock { get; set; }
        public int BookID { get; set; }
        public float BookWorth { get; }

    }
}
