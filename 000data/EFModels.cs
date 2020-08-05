using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp._000data
{
    public class Book
    {

        public int BookId { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }

        public string PublisherTitle { get; set; }

        /*[Required]
        //[DataType(DataType.Data)]
        //[Display(Name = "Release Date")]
        [Range(0,10)]*/

        //public DataSetDateTime Dob { get; set; }

        public string Author { get; set; }
        //public Author Author { get; set; }

    }
    
    public class Computer
    {

        public int ComputerId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter student name")]

        public string Title { get; set; }

        public string Author { get; set; }
        //public Author Author { get; set; }

        }
    
}
