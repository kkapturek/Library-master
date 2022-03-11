using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Document
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Number { get; set; }
        public int BookListID { get; set; }
        [Required]
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ConfirmDate { get; set; }
        public bool Comfirmed { get; set; }
    }
}
