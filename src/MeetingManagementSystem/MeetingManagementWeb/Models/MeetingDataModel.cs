namespace MeetingManagementWeb.Models
{
    public class MeetingDataModel
    {
        public MeetingMinutesMaster Master { get; set; }
        public List<MeetingMinutesDetails> Details { get; set; }

    }
}
