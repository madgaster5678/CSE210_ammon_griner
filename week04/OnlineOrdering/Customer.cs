using System;

public class Customer
{
    private string _customerName = "";
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool InUSA()
    {
        return _address.IsInUSA();
    }


}