using System;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ClassViewModel
    {
        public Guid Id { get; set; }

        [Display(Name="Nome")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Inicio")]
        [DisplayFormat(DataFormatString ="{0:D}")]
        [Required]
        public DateTime Start { get; set; }

        [Display(Name="Conclusão")]
        [DisplayFormat(DataFormatString = "{0:D}")]
        [Required]
        public DateTime End { get; set; }

        

        
    }
}
