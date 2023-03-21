class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool InUSA()
    {
        return _address.IsUSA();
    }
    public string MakeShipLabel()
    {
        return "Shipping Label"+"\n"+"Name: "+_name+"\n"+_address.FullAddress();
    }
}