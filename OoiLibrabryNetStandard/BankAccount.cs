namespace Ooi.Shared;


public class BankAccount
{
    public string AccountName; // instance member
    public decimal Balance; // instance member
    public static decimal InterestRate; // shared member
}

public class TextAndNumber
{
    public string Text;
    public int Number;
}

public class LifeTheUniverseAndEverything
{
    public TextAndNumber GetTheData()
    {
        return new TextAndNumber
        {
            Text = "What's the meaning of life?",
            Number = 50
        };
    }
}
