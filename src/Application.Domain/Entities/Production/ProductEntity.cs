namespace Application.Domain.Entities.Production;

public sealed class ProductEntity
{
    public string ProductId {get;set;}
    public string Name {get;set;}
    public int modelYear {get;set;}
    public List<decimal> ListPrice {get;set;}

//relationship
    public string CategoryId {get;set;}
    public CategoryEntity Category {get;set;}

    public string BrandId {get;set;}
    public BrandEntity Brand {get;set;}
}