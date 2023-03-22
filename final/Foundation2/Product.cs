public class Product
{
    public string _name { get; }
    public int _id { get; }
    public decimal _price { get; }
    public int _quantity { get; }

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price * quantity;
        _quantity = quantity;
    }
}