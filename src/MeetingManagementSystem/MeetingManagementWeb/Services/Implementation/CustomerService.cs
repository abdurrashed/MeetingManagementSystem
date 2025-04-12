using MeetingManagementWeb.Data;
using MeetingManagementWeb.Models;
using MeetingManagementWeb.Services.Interface;
using MeetingManagementWeb.ViewModel;

namespace MeetingManagementWeb.Services.Implementation
{
    public class CustomerService : ICustomerService
    {

        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CustomerViewModel> GetCorporateCustomers()
        {
            return _context.Corporate_Customer_Tbl
                .Select(c => new CustomerViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }

        public List<CustomerViewModel> GetIndividualCustomers()
        {
            return _context.Individual_Customer_Tbl
                .Select(c => new CustomerViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }
    }
}
