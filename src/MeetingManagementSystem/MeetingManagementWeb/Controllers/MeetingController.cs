using MeetingManagementWeb.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementWeb.Controllers
{
    public class MeetingController : Controller
    {

        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IMeetingService _meetingService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
