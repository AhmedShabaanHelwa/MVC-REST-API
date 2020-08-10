using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_REST_API.DTOs
{
    public class CommandCreateDto
    {
        //!AhmedShaban: Primary key is not intended to be provided
        //[Key]
        //public int Id { get; set; }
        //!comment: Validate the property inputs

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
