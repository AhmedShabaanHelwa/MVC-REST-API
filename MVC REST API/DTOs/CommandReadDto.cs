using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_REST_API.DTOs
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        //!comment: Validate the property inputs
        public string HowTo { get; set; }
        public string Line { get; set; }
        //!AhmedShaban: Platform is intended not to be mapped
        //public string Platform { get; set; }
    }
}
