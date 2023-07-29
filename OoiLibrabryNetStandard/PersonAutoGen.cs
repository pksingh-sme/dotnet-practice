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
}