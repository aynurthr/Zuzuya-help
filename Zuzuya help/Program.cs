int balance = 100;

bool exit = false;

while (!exit)
{
    Console.WriteLine("ATM Menu:");
    Console.WriteLine("[1] Show Balance");
    Console.WriteLine("[2] Cash In");
    Console.WriteLine("[3] Cash Out");
    Console.WriteLine("[0] Exit");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        ShowBalance();
    }
    else if (choice == "2")
    {
        CashIn();
    }
    else if (choice == "3")
    {
        CashOut();
    }
    else if (choice == "0")
    {
        exit = true;
        Console.WriteLine("Exiting the ATM. Thank you!");
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }

    Console.WriteLine();
}


void ShowBalance()
{
    Console.WriteLine($"Your current balance is: ${balance}");
}

void CashIn()
{
    Console.Write("Enter the amount to deposit: $");

    if (int.TryParse(Console.ReadLine(), out int amount))
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"${amount} deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid amount.");
    }
}

void CashOut()
{
    Console.Write("Enter the amount to withdraw: $");
    if (int.TryParse(Console.ReadLine(), out int amount))
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"${amount:F2} withdrawn successfully.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid amount.");
    }
}
