using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage ="The name Should have at least 2 chares anda a maxim 80")]//aceita maximo 80 carateries e no minimo 2 carater
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        
        [EmailAddress(ErrorMessage = "Please enter a valide email")]
        public string Email { get; set; }

        public bool? WillAttend { get; set; }
    }
}
