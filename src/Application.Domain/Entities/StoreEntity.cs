namespace Application.Domain.Entities.CustomerEntity;

public sealed class StoreEntity
{
    public string StoreId {get;set;}
    public string Name {get;set;}
    public string Phone {get;set;}
    public string Email {get;set;}
    public string Street {get;set;}
    public string City {get;set;}
    public string State {get;set;}
    public string ZipCode {get;set;}
    
    //relalationship
    public string CustomerId {get;set;}
    public CustomerEntity Customer {get;set;}

    public string StoreId {get;set;}
    public StoreEntity Customer {get;set;}
    
    public string StaffId {get;set;}
    public StaffEntity Staff {get;set;}
}