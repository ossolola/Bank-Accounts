using System;

public class SavingsAccount : BankAccount
{
    private const decimal Withdraw_Charge = 2.0m;
    private const int Withdraw_Limit = 3;
    private int Withdraw_Count = 0;
    public decimal InterestRate {get; set;}

    // Constructor
    public SavingsAccount(string fName, string lName, decimal Interest, decimal InitialBalance = 0.0M) 
        : base(fName, lName, InitialBalance) {
            InterestRate = Interest;

    }

    // Apply Interest Method
    public void ApplyInterest()
    {
        Balance += (Balance * InterestRate);
    }

    // Withdrawal
    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient Funds");
        }
        else {
            base.Withdraw(amount);

            Withdraw_Count++;

            // More than 3 withdrawals consecutively
            if (Withdraw_Count > Withdraw_Limit)
            {
                Console.WriteLine($"You will be charged ${Withdraw_Charge} for 3 consecutive withdrawals");
                amount += Withdraw_Charge;
                base.Withdraw(amount);
            }
        }
    }
}