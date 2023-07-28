namespace Ooi.Shared;


public class Person
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld BucketList;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    // constructors
    public Person()
    {
        // set default values for fields
        // including read-only fields
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public (string, int) GetFruit()
    {
        return ("Apple", 5);
    }
    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }



    // deconstructors
    public void Deconstruct(out string? name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }
    public void Deconstruct(out string? name, out DateTime dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = FavoriteAncientWonder;
    }

}

