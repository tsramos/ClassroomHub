using System;

namespace ClassroomHub.Web.ViewModels
{
    public class DeliveryViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeliveyDate { get; set; }
        public string Resolution { get; set; }
        public int Grade { get; set; }
        public Guid StudentId { get; set; }
        public Guid TeacherId { get; set; }

    }
}
