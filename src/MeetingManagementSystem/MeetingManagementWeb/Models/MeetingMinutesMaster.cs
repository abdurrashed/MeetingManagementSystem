using System.ComponentModel.DataAnnotations;

namespace MeetingManagementWeb.Models
{
    public class MeetingMinutesMaster
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "CustomerId is required.")]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "CustomerType is required.")]
        public string CustomerType { get; set; }

        [Required(ErrorMessage = "Meeting date and time is required.")]
        public DateTime MeetingDateTime { get; set; }

        [Required(ErrorMessage = "Meeting place is required.")]
        public string MeetingPlace { get; set; }

        [Required(ErrorMessage = "Attendees from client side are required.")]
        public string AttendsFromClientSide { get; set; }

        [Required(ErrorMessage = "Attendees from host side are required.")]
        public string AttendsFromHostSide { get; set; }

        [Required(ErrorMessage = "Meeting agenda is required.")]
        public string MeetingAgenda { get; set; }

        [Required(ErrorMessage = "Meeting discussion details are required.")]
        public string MeetingDiscussion { get; set; }

        [Required(ErrorMessage = "Meeting decision is required.")]
        public string MeetingDecision { get; set; }

    }
}
