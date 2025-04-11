namespace MeetingManagementWeb.Models
{
    public class MeetingMinutesMaster
    {
        public Guid CustomerId { get; set; }
        public string CustomerType { get; set; }
        public DateTime SessionDateTime { get; set; }
        public string SessionPlace { get; set; }
        public string AttendeesFromClientSide { get; set; }
        public string AttendeesFromHostSide { get; set; }
        public string SessionAgenda { get; set; }
        public string SessionDiscussion { get; set; }
        public string SessionDecision { get; set; }
    }
}
