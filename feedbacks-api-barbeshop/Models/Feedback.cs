using feedbacks_api_barbeshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace feedbacks_api_barbershop.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")] // Notação que indica a chave estrangeira
        public Cliente Cliente { get; set; } // Propriedade de navegação para o Cliente

        [Required]
        public int ServicoId { get; set; }

        [ForeignKey("ServicoId")] // Notação que indica a chave estrangeira
        public Servico Servico { get; set; } // Propriedade de navegação para o Serviço

        [Required]
        [Range(1, 5)]
        public int Classificacao { get; set; }

        [Required]
        public string Comentarios { get; set; }

        [Required]
        public DateTime DataFeedback { get; set; }
    }
}

