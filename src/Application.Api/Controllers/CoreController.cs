namespace Application.Api.Controllers;

[Route("products")]
[ApiController]
public class CoreController
{
    private readonly IProductsRepository _productsRepository;

    public CoreController(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository
    }

    [HttpGet]
    public async List<ProductsEntity> ProductsOutOfStock()
    {
        var result = await _productsRepository.GetOutOfStock();

        return new {data: result, count: result.Count()}
    } 
}