using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class CourseViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Nome do Curso")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayName("Descríção")]
        [MaxLength(400)]
        public string Description { get; set; }
    }
}
