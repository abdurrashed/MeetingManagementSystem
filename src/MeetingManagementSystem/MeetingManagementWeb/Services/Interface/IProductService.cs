using MeetingManagementWeb.Models;

namespace MeetingManagementWeb.Services.Interface
{
    public interface IProductService
    {

        List<Product> GetProductServices();
        string GetUnitByProductId(Guid productId);
    }
}
