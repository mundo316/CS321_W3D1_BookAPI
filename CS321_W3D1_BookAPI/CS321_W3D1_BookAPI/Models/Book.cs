using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D1_BookAPI.Models
{
    public class Book
    {
            public int Id { get; set; }
            [Required (ErrorMessage = "Title is Required")]
            public string Title { get; set; }
            [Required(ErrorMessage ="Author is Required")]
            public string Author { get; set; }
            [Required(ErrorMessage ="Category is Required")]
            public string Category { get; set; }
        
    }
}
