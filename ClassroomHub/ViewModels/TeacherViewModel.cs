using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public sealed class TeacherViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
         
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sobrenome obrigatório")]
        [DisplayName("Sobrenome")]
        public string Surname { get; set; }

        public string Especializacao { get; set; }

        public string Email { get; set; }
    }
}
