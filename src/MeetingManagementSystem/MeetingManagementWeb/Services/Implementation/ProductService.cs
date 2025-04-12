using MeetingManagementWeb.Data;
using MeetingManagementWeb.Models;
using MeetingManagementWeb.Services.Interface;
using System.Reflection.Metadata.Ecma335;

namespace MeetingManagementWeb.Services.Implementation
{
    public class ProductService : IProductService
    {

        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {

            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products_Service_Tbl.ToList();
        }

        public string GetUnitByProductId(Guid productId)
        {
            var product = _context.Products_Service_Tbl.Find(productId);

            return product.Unit;
        }
    }
}
