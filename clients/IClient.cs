using Products.Library.Contracts;
using System.Threading.Tasks;

namespace Products.Library.Clients
{
  public interface IClient
  {
    Task<GetProductsResponse1> GetProducts(GetProductsRequest request);
    Task<GetProductDetailsResponse1> GetProductDetails(GetProductDetailsRequest request);
  }
}