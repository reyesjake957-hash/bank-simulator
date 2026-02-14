class BankingView
{
    private BankingServices _bankingServices;

    public BankingView(BankingServices bankingServices)
    {
        _bankingServices = bankingServices;
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nBanking Menu:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check Balance");
        Console.WriteLine("4. Exit");
    }

    public void ProcessUserInput()
    {
        bool exit = false;

        while (!exit)
        {
            ShowMenu();
            Console.Write("Please choose an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter amount to deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        _bankingServices.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid number.");
                    }
                    break;
                case "2":
                    Console.Write("Enter amount to withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                    {
                        _bankingServices.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid number.");
                    }
                    break;
                case "3":
                    _bankingServices.CheckBalance();
                    break;
                case "4":
                    Console.WriteLine($"Thank you for using the Banking Services, {_bankingServices.AccountHolder}!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Display your name above the title
        string myName = "John Doe";  // Change this to your name
        Console.WriteLine($"Welcome to Banking Services - by {myName}\n");

        // Title of the simulator
        Console.WriteLine("Banking Services\n");

        // Ask for account holder name and create an account
        Console.Write("Enter your name: ");
        string accountHolder = Console.ReadLine();
        BankingServices bankingServices = new BankingServices(accountHolder);

        // Create a Banking View to interact with the user
        BankingView bankingView = new BankingView(bankingServices);

        // Start processing user input through the view
        bankingView.ProcessUserInput();
    }
}
