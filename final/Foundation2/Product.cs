using System;

public class Product
{
    private string _productName;
    private string _productID;
    private  double _price;
    private int _quantity;

    public Product(string product, string productID, double price, int quantity)
    {
        _productName = product;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public void SetProductName(string product)
    {
        _productName = product;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetQuantity( int quantity)
    {
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}