namespace LibObjects;

public class BankAccount 
{
    public string Owner 
    {
        get {
            return owner;
        } 
        set {
            owner = value;
        }
    }
    
    public double Balance 
    {
        get {
            return balance;
        } 
        set {
            if (value > 10)
            {
                balance = value;
            }
        }
    }
    
    private string owner = String.Empty;
    private double balance;

    public BankAccount(string name, double value)
    {
        Owner = name;
        Balance = value;
    } 

    public double getBalance()
    {
        return Balance;
    }

    public string getOwner()
    {
        return Owner;
    }
}