using System;

class Program
{
    static void Main(string[] args)
    {
        
        Customer customer1 = new("John Doe");
        Address address1 = new("102 Lehi Street", "Salt Lake", "Utah", "USA");
        Product customer1Product1 = new("Shower Gel","123", 29.99, 5);
        Product customer1Product2 = new("6 pack Soda","3456",5.50, 4);
        Product customer1Product3 = new("Football", "5678", 21.65, 2);
        Order order1 = new(customer1, customer1Product1,address1);
        order1._productList.Add(customer1Product1);
        order1._productList.Add(customer1Product2);
        order1._productList.Add(customer1Product3);
        order1.SetTotalCost(address1);
        order1.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order1.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(" _______________________________________");
        Console.WriteLine();

        Customer customer2 = new("Betty Pretty");
        Address address2 = new("151 Jubuluzufe Road", "Durban", "KwaZulu-Natal", "South Africa");
        Product customer2Product1 = new("Rooibos Teabags","1324", 15.49, 10);
        Product customer2Product2 = new("6 pack Soda","3456",5.50, 4);
        Product customer2Product3 = new("Doritos", "5658", 2.20, 5);
        Order order2 = new(customer2, customer2Product1,address2);
        order2._productList.Add(customer2Product1);
        order2._productList.Add(customer2Product2);
        order2._productList.Add(customer2Product3);
        order2.SetTotalCost(address2);
        order2.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order2.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(" _______________________________________");
        Console.WriteLine();
       
       


    }
}