namespace Application.Domain.Entities.Production;

public sealed class CategoryEntity
{
    public string CategoryId {get;set;}
    public string Name {get;set;}

//relationship
    public List<ProductEntity>? Products {get;set;}
}