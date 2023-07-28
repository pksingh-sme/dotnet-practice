using Ooi.Shared;

//Thread.CurrentThread.CurrentCulture =  System.Globalization.CultureInfo.GetCultureInfo("en-GB");


Person bob = new();

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");


/*
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later

bob.FavoriteAncientWonder =
  WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);


bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();

WriteLine("{0} is {1:N0}", arg0: fruit.Item1, arg1: fruit.Item2);

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

LifeTheUniverseAndEverything l = new();
TextAndNumber tn = l.GetTheData();

WriteLine("{0} is {1:N0}", arg0: tn.Text, arg1: tn.Number);

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

var thing3 = (bob.Name, bob.Children.Count, bob.DateOfBirth);
WriteLine($"{thing3.Name} has {thing3.Count} children {thing3.DateOfBirth:dddd}.");


(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// Deconstructing a Person
var (name1, dob1) = bob; // implicitly calls the Deconstruct method
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.OptionalParameters());

*/