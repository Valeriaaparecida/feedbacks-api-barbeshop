using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace feedbacks_api_barbershop.Models
{
    public class Servico
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        // Outros campos relevantes para o serviço.

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
