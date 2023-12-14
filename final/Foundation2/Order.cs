using System;

public class Order
{
    public List<Product>_productList = new();
    private double _totalCost = 0;
    private string _shippingLabel;

    public Order(Customer customer, Product product, Address address )
    {
        _shippingLabel = $"{customer.GetCustomerName()}\n-------------\n{address.GetAddress()}";
    }
    public void SetTotalCost(Address address)
    {   
        foreach( Product product in _productList)
        {
           _totalCost += (product.GetPrice()*product.GetQuantity());
        }
        if (address.isUSA() == true)
        {
            _totalCost += 5;
            Math.Round(_totalCost , 2);
        }
        else
        {
            _totalCost += 35;
           Math.Round(_totalCost, 2) ;
        }
    }
    public double GetTotalCost()
    {
        return _totalCost;
    }
    public void DisplayPackingLabel()
    {
        foreach( Product product in _productList)
        {
            Console.WriteLine($"Product: {product.GetProductName()}\nProduct ID:{product.GetProductID()}\n");
        }
    }
    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

}