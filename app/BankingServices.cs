using System;

class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountHolder, double initialBalance = 0)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance is {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance is {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is {Balance}");
    }
}
