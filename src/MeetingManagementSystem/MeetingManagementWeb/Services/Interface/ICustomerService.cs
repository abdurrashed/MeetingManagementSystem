using MeetingManagementWeb.Models;
using MeetingManagementWeb.ViewModel;

namespace MeetingManagementWeb.Services.Interface
{
    public interface ICustomerService
    {
        List<CustomerViewModel> GetCorporateCustomers();
        List<CustomerViewModel> GetIndividualCustomers();
    }
}
