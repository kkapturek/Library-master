using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Every book has an Name!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Every book has an Author!")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Every book has a Relase Date!"), DataType(DataType.Date),Display(Name="Relase Date")]
        public DateTime RelaseDate { get; set; }
        [Display(Name ="Author Value")]
        public float ValueForAuthor { get; set; }
        [Required(ErrorMessage ="We need to have some Worth ;)"),Display(Name ="Our Worth")]
        public float LibWorth { get; set; }
    }
}
