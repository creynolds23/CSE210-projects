public class Order
{
    private List<Product> _products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product._price;
        }
        if (customer.Address.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product._name} ({product._id})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{customer._name}\n{customer.Address.ToString()}";
    }
}