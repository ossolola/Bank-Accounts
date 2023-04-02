using System;

public class BankAccount
{
    private string _firstName;
    private string _lastName;
    public decimal Balance {get; set;}

    // Constructor
    public BankAccount(string fName, string lName, decimal InitialBalance = 0.0m)
    {
        _firstName = fName;
        _lastName = lName;
        Balance = InitialBalance;
    }

    // Returning Account Owner
    public string AccountOwner
    {
        get {
            return $"{_firstName} {_lastName}";
        }
    }

    // Deposit Method
    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    // Withdrawal
    public virtual void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}