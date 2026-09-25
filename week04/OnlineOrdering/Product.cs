using System;

public class Product
{
    private string _productName = "";
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, int productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal PriceForProduct()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }


}