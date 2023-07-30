namespace Ooi.Shared;

public partial class Person
{

    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}", arg0: Name, arg1: HomePlanet);
        }
    }

    public string Greeting => $"{Name} sy 'Hello'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

    public string? FavoriteIceCream { get; set; }

    // a private field to store the property value
    private string? favoritePrimaryColor;
    // a public property to read and write to the field
    public string? FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                      $"{value} is not a primary color. " +
                      "Choose from: red, green, blue.");
            }
        }
    }

    // indexers
    public Person this[int index]
    {
        get
        {
            return Children[index]; // pass on to the List<T> indexer
        }
        set
        {
            Children[index] = value;
        }
    }
    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
        set
        {
            Person found = Children.Find(p => p.Name == name);
            if (found is not null) found = value;
        }
    }



    private bool married = false;
    public bool Married => married;
    private Person? spouse = null;
    public Person? Spouse => spouse;

    public static void Marry(Person p1, Person p2)
    {
        p1.Marry(p2);
    }
    // instance method to marry
    public void Marry(Person partner)
    {
        if (married) return;
        spouse = partner;
        married = true;
        partner.Marry(this); // this is the current object
    }
}