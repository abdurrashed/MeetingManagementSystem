using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetingManagementWeb.Models
{
    public class MeetingMinutesDetails
    {

        public Guid Id { get; set; }
        public Guid MeetingMinutesId { get; set; }
        public Guid ProductId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }
    }
}
