using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MingleBee.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }


        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage ="You must specify password brtween 4 and 8 charecters")]
        public string Password { get; set; }
    }
}
