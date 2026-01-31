using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Willoby St", "Arizona", "USA", "Phoenix");
        Customer customer1 = new Customer("Luke Stone", address1);
        Order order1 = new Order(customer1);
        Address address2 = new Address("Adolfo Ibañez", "Puebla", "México", "Puebla");
        Customer customer2 = new Customer("Ernesto Silva", address2);
        Order order2 = new Order(customer2);

        Product product1 = new Product("Milk", "2210", 2.50, 2);
        Product product2 = new Product("PS5", "10302", 549.99, 1);
        Product product3 = new Product("Keyboard", "20031", 99.99, 1);
        Product product4 = new Product("Eggs", "2211", 0.75, 30);
        Product product5 = new Product("Bread", "1205", 3.00, 3);
        Product product6 = new Product("Mouse", "10111", 50.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product6);


        Console.WriteLine("ORDER N1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine();
        Console.WriteLine("ORDER N2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}