namespace Application.Domain.Entities.Sales;

public sealed class StaffEntity
{
    public string StaffId {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Phone {get;set;}
    public string Email {get;set;}
    public bool Active {get;set;} = true;

//relationship
    public string StoreId {get;set;}
    public StoreEntity Store {get;set;}

    public string? ManagerId {get;set;} = null;
}