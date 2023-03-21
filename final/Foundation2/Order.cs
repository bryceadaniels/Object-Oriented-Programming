class Order
{
    List<Product> _products;
    Customer _customer;
    public Order (Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public float CalcTotalPrice()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += product.CalcCost();
        }
        if (_customer.InUSA()==true)
        {
            total += 5f;
        }
        else
        {
            total += 35f;
        }
        return total;
    }
    public string MakePackLabel()
    {
        string label = "Packing Label";
        foreach(Product product in _products)
        {
            label = label + product.MakePackLabel();
        }
        return label;
    }
    public void DisplayPackingLabel()
    {
        System.Console.WriteLine("Packing Label");
        foreach(Product product in _products)
        {
            System.Console.WriteLine(product.MakePackLabel());
        }
    }
    public string MakeShipLabel()
    {
        return _customer.MakeShipLabel();
    }
    public void DisplayShippingLabel()
    {
        System.Console.WriteLine(_customer.MakeShipLabel());
    }
}