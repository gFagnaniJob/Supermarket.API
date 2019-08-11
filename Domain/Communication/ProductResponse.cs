using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Communication
{
    public class ProductResponse : BaseResponse
    {
         public Product Product {get; private set;}
    private ProductResponse(bool success, string message, Product product) : base(success, message)
    {
        Product = product;
    }

    /// <summary>
    /// Creates a success response.
    /// </summary>
    /// <param name="product">Saved product.</param>
    ///<returns>Response.</returns>
    public ProductResponse(Product product) : this(true, string.Empty, product) {}

    /// <summary>
    /// Creates an error response.
    /// </summary>
    /// <param name="message">Error message.</param>
    ///<returns>Response.</returns>
    public ProductResponse(string message) : this(false, message, null) {}
    }
}