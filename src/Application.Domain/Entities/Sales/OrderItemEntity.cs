namespace Application.Domain.Entities.Sales;

public sealed class OrderItemEntity
{
    public string OrderId {get;set;}
    public string ItemId {get;set;} // mesmo que productId
    public string ProductId {get;set;}
    public int Quantity {get;set;}
    public List<decimal>? ListPrice {get;set;}
    public decimal? Discount {get;set;}
}