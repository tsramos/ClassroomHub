using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class ActivityViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [DisplayName("Titulo")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Data de entrega")]
        public DateTime DueDate { get; set; }
        public int ActivityScore { get; set; }
        public string TeacherName { get; set; }
        public Guid TeacherId { get; set; }
        public string ModuleName { get; set; }
        public Guid ModuleId { get; set; }
        public IEnumerable<DeliveryViewModel> Deliveries { get; set; }
    }
}
