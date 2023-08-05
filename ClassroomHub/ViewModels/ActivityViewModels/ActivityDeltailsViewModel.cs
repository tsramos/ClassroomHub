using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class ActivityDeltailsViewModel
    {
        public Guid ActivityId { get; set; }
        public Guid StudentId { get; set; }

        public DateTime DeliveyDate { get; set; }
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

    }
}
