using System.Collections.Generic;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class DeliveryToTeacherViewModel
    {        
        public string Name { get; set; }
        public IEnumerable<ActivityViewModel> Activities { get; set; }
    }
}
