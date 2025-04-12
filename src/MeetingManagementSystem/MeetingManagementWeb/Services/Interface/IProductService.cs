using MeetingManagementWeb.Models;

namespace MeetingManagementWeb.Services.Interface
{
    public interface IProductService
    {

        List<Product> GetProducts();
        string GetUnitByProductId(Guid productId);
    }
}
