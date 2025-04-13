using MeetingManagementWeb.Models;
using MeetingManagementWeb.Services.Interface;
using MeetingManagementWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementWeb.Controllers
{
    public class MeetingController : Controller
    {

        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IMeetingService _meetingService;


        public MeetingController(ICustomerService customerService, IProductService productService, IMeetingService meetingService)
        {
            _customerService = customerService;
            _productService = productService;
            _meetingService = meetingService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Products = _productService.GetProducts();
            return View();
        }

        [HttpGet]
        public PartialViewResult GetCustomers(string type)
        {
            List<CustomerViewModel> customers;

            if (type == "Corporate")
            {
                customers = _customerService.GetCorporateCustomers();
            }
            else
            {
                customers = _customerService.GetIndividualCustomers();
            }

            return PartialView("_CustomerDropdown", customers);
        }

        [HttpGet]
        public ContentResult GetUnit(Guid productId)
        {
            var unit = _productService.GetUnitByProductId(productId);
            return Content(unit);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveMeeting(MeetingDataModel data)
        {


            data.Master.Id = Guid.NewGuid();
            foreach (var detail in data.Details)
            {
                detail.MeetingMinutesId = data.Master.Id;
            }




            if (data != null)
            {
                if (ModelState.IsValid)
                {
                    _meetingService.SaveMeeting(data.Master, data.Details);

                }
               
                TempData["SuccessMessage"] = "Meeting saved successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Invalid meeting data.";
            }
            return RedirectToAction("Index");
        }



    }
}
