using Microsoft.Extensions.Options;
using Products.Library.Contracts;
using Products.Library.Options;
using System.Threading.Tasks;

namespace Products.Library.Clients
{
  public class Client : IClient
  {
    protected readonly EnvironmentOptions _options;

    public Client(
      IOptions<EnvironmentOptions> options
    )
    {
      _options = options.Value;
    }

    public async Task<GetProductsResponse1> GetProducts(GetProductsRequest request)
    {
      // TODO: Customize URLs in configuration after initial lift
      var client = new ProductsPortTypeClient();

      return await client.GetProductsAsync(request);
    }

    public async Task<GetProductDetailsResponse1> GetProductDetails(GetProductDetailsRequest request)
    {
      var client = new ProductsPortTypeClient();

      return await client.GetProductDetailsAsync(request);
    }
  }
}