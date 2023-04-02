using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the Checking Account with initial balance
            CheckingAccount CheckAcc1 = new CheckingAccount("Solola", "Oluwasemilore", 2500.0m);

            // Create the Savings Account with interest and Initial Balance
            SavingsAccount SavingsAcc1 = new SavingsAccount("Ademolu", "Opemipo", 0.025m, 1000.0m);

            // Check Balances
            Console.WriteLine($"Checking Balance is {CheckAcc1.Balance:C2}");
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");

            // Print the account owner information
            Console.WriteLine($"Checking Account Owner {CheckAcc1.AccountOwner:C2}");
            Console.WriteLine($"Checking Account Owner {SavingsAcc1.AccountOwner:C2}");

            // Deposit into individual Accounts
            CheckAcc1.Deposit(200.0m);
            SavingsAcc1.Deposit(150.0m);

            // Check Balances
            Console.WriteLine($"Checking Balance is {CheckAcc1.Balance:C2}");
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");

            // Withdraw from accounts
            CheckAcc1.Withdraw(50.0m);
            SavingsAcc1.Withdraw(125.0m);

            // Check Balances
            Console.WriteLine($"Checking Balance is {CheckAcc1.Balance:C2}");
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");

            // Apply Interest to the Savings Account
            SavingsAcc1.ApplyInterest();
            // Check Savings Account Balance
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");

            // More than 3 Withdrawals should result in 2.00 Charge
            SavingsAcc1.Withdraw(10.0m);
            SavingsAcc1.Withdraw(20.0m);
            SavingsAcc1.Withdraw(30.0m);
            // Check Savings Account Balance
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");

            // Overdraw savings 
            SavingsAcc1.Withdraw(2000.0m);

            // overdraw Checking
            CheckAcc1.Withdraw(3000.0m);

            // Check Both Balances
            Console.WriteLine($"Checking Balance is {CheckAcc1.Balance:C2}");
            Console.WriteLine($"Savings balance is {SavingsAcc1.Balance:C2}");
    }
}