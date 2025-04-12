using MeetingManagementWeb.Data;
using MeetingManagementWeb.Models;
using MeetingManagementWeb.Services.Interface;

namespace MeetingManagementWeb.Services.Implementation
{
    public class CustomerService : ICustomerService
    {

        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {

            _context = context;
        }
        public List<CorporateCustomer> GetCorporateCustomers()
        {
            return _context.Corporate_Customer_Tbl.ToList();
        }

        public List<IndividualCustomer> GetIndividualCustomers()
        {
            return _context.Individual_Customer_Tbl.ToList();
        }
    }
}
