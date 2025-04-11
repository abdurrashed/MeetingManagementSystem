using MeetingManagementWeb.Models;

namespace MeetingManagementWeb.Services.Interface
{
    public interface IMeetingService
    {
        void SaveMeeting(MeetingMinutesMaster master, List<MeetingMinutesDetails> details);
    }
}
