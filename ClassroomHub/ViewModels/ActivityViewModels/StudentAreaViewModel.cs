using System.Collections.Generic;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class StudentAreaViewModel
    {
        public string ModuleName { get; set; }
        public List<ActivityViewModel> Activities { get; set; }
    }
}
