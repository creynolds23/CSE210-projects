
    Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
    Customer customer1 = new Customer("John Doe", address1);

    Product product1 = new Product("Clock", 1, 10.0m, 2);
    Product product2 = new Product("Gadget", 2, 5.0m, 3);

    Order order1 = new Order(customer1);
    order1.AddProduct(product1);
    order1.AddProduct(product2);

    decimal totalCost = order1.CalculateTotalCost();
    string packingLabel = order1.GetPackingLabel();
    string shippingLabel = order1.GetShippingLabel();

    Address address2 = new Address("456 Not Main St", "SomeTown", "ON", "Canada");
    Customer customer2 = new Customer("Bill Collins", address2);

    Product product3 = new Product("Timer", 1, 50.0m, 1);
    Product product4 = new Product("Basketball", 2, 25.0m, 2);
    Order order2 = new Order(customer2);
    order2.AddProduct(product3);
    order2.AddProduct(product4);

    decimal totalCost2 = order2.CalculateTotalCost();
    string packingLabel2= order2.GetPackingLabel();
    string shippingLabel2 = order2.GetShippingLabel();

    Console.WriteLine("Order 1:");
    Console.WriteLine($"Total cost: {totalCost:C}");
    Console.WriteLine($"Packing label:\n{packingLabel}");
    Console.WriteLine($"Shipping label:\n{shippingLabel}");

    Console.WriteLine("\nOrder 2:");
    Console.WriteLine($"Total cost: {totalCost2:C}");
    Console.WriteLine($"Packaging label:\n{packingLabel2}");
    Console.WriteLine($"Shipping label: \n{shippingLabel2}");