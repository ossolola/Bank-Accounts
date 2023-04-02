using System;

public class CheckingAccount : BankAccount
{
    private const decimal Overwithdraw_Charge = 35.0m;

    public CheckingAccount(string fName, string lName, decimal InitialBalance = 0.0M) 
        : base(fName, lName, InitialBalance) {
    }

    public override void Withdraw(decimal amount)
    {
        // if account gets overwithdrawn, there's a charge
        
        if (amount > Balance)
        {
            amount += Overwithdraw_Charge;
        }
        base.Withdraw(amount);
    }
}