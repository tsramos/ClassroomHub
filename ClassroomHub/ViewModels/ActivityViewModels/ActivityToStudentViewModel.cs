using System;

namespace ClassroomHub.Web.ViewModels.ActivityViewModels
{
    public class ActivityViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int ActivityScore { get; set; }
        public string TeacherName { get; set; }
        public string ModuleName { get; set; }
        public Guid ModuleId { get; set; }

        public string Resolution { get; set; }
    }
}
