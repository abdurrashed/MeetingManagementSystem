using MeetingManagementWeb.Models;

namespace MeetingManagementWeb.Services.Interface
{
    public interface IProductService
    {

        List<ProductService> GetProductServices();
        string GetUnitByProductId(Guid productId);
    }
}
