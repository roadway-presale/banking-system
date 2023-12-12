// BankSystem.cs

class BankSystem
{
    static void Main()
    {
        // Create customers
        Customer customer1 = new Customer(1, "Alice");
        Customer customer2 = new Customer(2, "Bob");

        // Create accounts
        Account account1 = new Account(101, customer1, 1000);
        Account account2 = new Account(102, customer2, 500);

        // Display initial balances
        Console.WriteLine("Initial Balances:");
        account1.DisplayInfo();
        account2.DisplayInfo();

        // Perform a transaction
        Transaction transaction = new Transaction(account1, account2, 300);
        transaction.ExecuteTransaction();

        // Display updated balances
        Console.WriteLine("\nUpdated Balances:");
        account1.DisplayInfo();
        account2.DisplayInfo();
    }
}
