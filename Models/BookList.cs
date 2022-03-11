using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookList
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Number { get; set; }
       // [ForeignKey("BookID")]
        public int BookID { get; set; }
        public DateTime AddToListDate { get; set; }
        public int Quantity { get; set; }

    }
}
