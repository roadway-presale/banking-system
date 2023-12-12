// Customer.cs

public class Customer
{
    private int customerId;
    private string name;

    public Customer(int customerId, string name)
    {
        this.customerId = customerId;
        this.name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {name}");
    }
}
