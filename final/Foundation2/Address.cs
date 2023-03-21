class Address
{
    private string _streetAddress="";
    private string _city="";
    private string _state="";
    private string _country="";
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "USA"| _country == "US" | _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string FullAddress()
    {
        return _streetAddress + "\n" + _city + ", " + _state + ' ' + _country; 
    }
}