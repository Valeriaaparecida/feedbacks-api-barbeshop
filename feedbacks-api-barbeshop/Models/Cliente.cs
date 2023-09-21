using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace feedbacks_api_barbershop.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
