using MeetingManagementWeb.Models;

namespace MeetingManagementWeb.Services.Interface
{
    public interface ICustomerService
    {
        List<CorporateCustomer> GetCorporateCustomers();
        List<IndividualCustomer> GetIndividualCustomers();
    }
}
