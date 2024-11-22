namespace Application.Domain.Entities.Sales;

public sealed class CustomerEntity
{
    public string CustomerId {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Phone {get;set;}
    public string Email {get;set;}
    public string Street {get;set;}
    public string City {get;set;}
    public string State {get;set;}
    public string ZipCode {get;set;}

    //relalationship
    public List<OrderEntity>? Orders {get;set;}
}