using Ooi.Shared;

//Thread.CurrentThread.CurrentCulture =  System.Globalization.CultureInfo.GetCultureInfo("en-GB");

Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later

bob.BucketList =
  WondersOfTheAncientWorld.HangingGardensOfBabylon
  | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");




bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 and later

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}



BankAccount.InterestRate = 0.012M;

BankAccount johnAccount = new();
johnAccount.AccountName = "My John Shaw";
johnAccount.Balance = 5000;

WriteLine(format: "{0} earned {1:C} interest.", arg0: johnAccount.AccountName, arg1: johnAccount.Balance * BankAccount.InterestRate);

BankAccount garyAccount = new();
garyAccount.AccountName = "Mr. Gary Moore";
garyAccount.Balance = 100;

WriteLine(format: "{0} earned {1:C} interest.", arg0: garyAccount.AccountName, arg1: garyAccount.Balance * BankAccount.InterestRate);
