class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetId()
    {
        return this.id;
    }

    public double GetPrice()
    {
        return this.price * this.quantity;
    }
}