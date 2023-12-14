using System;

public class Customer
{
    private string _customerName;
    
    public Customer(string customerName)
    {   
        _customerName = customerName;
    }
    public void SetCustomerName(string customer)
    {
        _customerName = customer;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
}