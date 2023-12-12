// Transaction.cs

public class Transaction
{
    private Account sourceAccount;
    private Account destinationAccount;
    private double amount;

    public Transaction(Account sourceAccount, Account destinationAccount, double amount)
    {
        this.sourceAccount = sourceAccount;
        this.destinationAccount = destinationAccount;
        this.amount = amount;
    }

    public void ExecuteTransaction()
    {
        if (sourceAccount.GetBalance() >= amount)
        {
            sourceAccount.Withdraw(amount);
            destinationAccount.Deposit(amount);
            Console.WriteLine("Transaction successful");
        }
        else
        {
            Console.WriteLine("Transaction failed: Insufficient funds");
        }
    }
}
