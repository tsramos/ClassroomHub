namespace ClassroomHub.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    public class StudentViewModel
    {
        [Display(Name= "Nome")]
        [Required(ErrorMessage ="Nome do aluno é obrigatório.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
