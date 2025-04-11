using System.ComponentModel.DataAnnotations;

namespace MeetingManagementWeb.Models
{
    public class MeetingMinutesMaster
    {
        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public string CustomerType { get; set; }

        [Required]
        public DateTime MeetingDateTime { get; set; }

        [Required]
        public string MeetingPlace { get; set; }

        [Required]
        public string AttendsFromClientSide { get; set; }

        [Required]
        public string AttendsFromHostSide { get; set; }

        [Required]
        public string MeetingAgenda { get; set; }

        [Required]
        public string MeetingDiscussion { get; set; }

        [Required]
        public string MeetingDecision { get; set; }
    }
}
