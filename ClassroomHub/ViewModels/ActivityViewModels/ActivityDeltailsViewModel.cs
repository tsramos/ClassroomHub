using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class ActivityDeltailsViewModel
    {
        [Required]
        public Guid ActivityId { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        [DisplayName("Data de entrega")]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [DisplayName("Solução da atividade.")]
        public string Resolution { get; set; }

        [DisplayName("Titulo")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Data de entrega")]
        public DateTime DueDate { get; set; }

        public int ActivityScore { get; set; }

        public bool Delivered { get; set; }

    }
}
