using MeetingManagementWeb.Data;
using MeetingManagementWeb.Models;
using MeetingManagementWeb.Services.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.Data;

namespace MeetingManagementWeb.Services.Implementation
{
    public class MeetingService : IMeetingService
    {
        private readonly ApplicationDbContext _context;
        public MeetingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void SaveMeeting(MeetingMinutesMaster master, List<MeetingMinutesDetails> details)
        {
            using var connection = _context.Database.GetDbConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "Meeting_Minutes_Master_Save_SP";
            command.CommandType = CommandType.StoredProcedure;

            var meetingId = Guid.NewGuid();
            master.Id = meetingId;
            command.Parameters.Add(new SqlParameter("@Id", master.Id));
            command.Parameters.Add(new SqlParameter("@CustomerId", master.CustomerId));
            command.Parameters.Add(new SqlParameter("@CustomerType", master.CustomerType));
            command.Parameters.Add(new SqlParameter("@MeetingDateTime", master.MeetingDateTime));
            command.Parameters.Add(new SqlParameter("@MeetingPlace", master.MeetingPlace));
            command.Parameters.Add(new SqlParameter("@AttendsFromClientSide", master.AttendsFromClientSide));
            command.Parameters.Add(new SqlParameter("@ AttendsFromHostSide ", master.AttendsFromHostSide));
            command.Parameters.Add(new SqlParameter("@MeetingAgenda", master.MeetingAgenda));
            command.Parameters.Add(new SqlParameter("@MeetingDiscussion", master.MeetingDiscussion));
            command.Parameters.Add(new SqlParameter("@MeetingDecision", master.MeetingDecision));
            command.ExecuteNonQuery();


            foreach (var item in details)
            {
                using var detailCmd = connection.CreateCommand();
                detailCmd.CommandText = "Meeting_Minutes_Details_Save_SP";
                detailCmd.CommandType = CommandType.StoredProcedure;

                item.Id = Guid.NewGuid(); 
                item.MeetingMinutesId = master.Id; 

                detailCmd.Parameters.Add(new SqlParameter("@Id", item.Id));
                detailCmd.Parameters.Add(new SqlParameter("@MeetingMinutesId", item.MeetingMinutesId));
                detailCmd.Parameters.Add(new SqlParameter("@ServiceProductId", item.ServiceProductId));
                detailCmd.Parameters.Add(new SqlParameter("@Quantity", item.Quantity));

                detailCmd.ExecuteNonQuery();
            }



        }
    }
}
