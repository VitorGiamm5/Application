namespace Application.Domain.Entities.Sales;

public sealed class OrderEntity
{
    public string OrderId {get;set;}
    public string FirstName {get;set;}
    public StatusOrderEnum Status {get;set;}
    public DateTime CreatedDate {get;set;}
    public DateTime? RequiredDate {get;set;}
    public DateTime? ShippedDate {get;set;}

    //relalationship
    public string CustomerId {get;set;}
    public CustomerEntity Customer {get;set;}

    public string StoreId {get;set;}
    public StoreEntity Customer {get;set;}
    
    public string StaffId {get;set;}
    public StaffEntity Staff {get;set;}
}