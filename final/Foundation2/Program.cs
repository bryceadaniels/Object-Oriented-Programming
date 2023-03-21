using System;

class Program
{
    static void Main(string[] args)
    {
        Address addy1 = new Address("3853 Bluffview Dr", "Marietta","GA", "USA");
        Customer person1 = new Customer("Bryce",addy1);
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("Orange Chicken", 101,3.01f,2);
        Product product2 = new Product("Chow Mein", 102, 2.10f,1);
        products1.Add(product1);
        products1.Add(product2);
        Order order1 = new Order(person1,products1);
        System.Console.WriteLine("Order 1");
        System.Console.WriteLine($"Total Price: {order1.CalcTotalPrice()}");
        System.Console.WriteLine();
        order1.DisplayPackingLabel();
        System.Console.WriteLine();
        order1.DisplayShippingLabel();
        System.Console.WriteLine();

        Address addy2 = new Address("8565 Random St", "Ottowa", "Ontario", "Canada");
        Customer person2 = new Customer("Luc",addy2);
        List<Product> products2 = new List<Product>();
        Product product3 = new Product("Poutine", 201,4.01f,2);
        Product product4 = new Product("Maple Syrup", 202, 2.10f,1);
        products2.Add(product3);
        products2.Add(product4);
        Order order2 = new Order(person2,products2);
        System.Console.WriteLine("Order 2");
        System.Console.WriteLine($"Total Price: {order2.CalcTotalPrice()}");
        System.Console.WriteLine();
        order2.DisplayPackingLabel();
        System.Console.WriteLine();
        order2.DisplayShippingLabel();
        System.Console.WriteLine();
    }
}