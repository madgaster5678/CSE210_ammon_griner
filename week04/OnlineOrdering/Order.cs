using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _productList;
    private Customer _customerInfo;

    public Order(List<Product> productList, Customer customerInfo)
    {
        _productList = productList;
        _customerInfo = customerInfo;
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        decimal shipping = 0;

        foreach (Product product in _productList)
        {
            total += product.PriceForProduct();
        }

        
        if (_customerInfo.InUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        total += shipping;
        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productList)
        {
            packingLabel += $"Product: {product.GetName()}\nProduct ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customerInfo.GetName()}\n{_customerInfo.GetAddress().GetFullAddress()}";
    }

}