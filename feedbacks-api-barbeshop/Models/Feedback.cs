
 using System;
 using System.ComponentModel.DataAnnotations;

   namespace feedbacks_api_barbeshop.Models
{
        public class Feedback
        {
            public int Id { get; set; }

            [Required]
            public int ClienteId { get; set; }

            [Required]
            public int ServicoId { get; set; }

            [Required]
            [Range(1, 5)]
            public int Classificacao { get; set; }

            [Required]
            public string Comentarios { get; set; }

            [Required]
            public DateTime DataFeedback { get; set; }
        }
    }
