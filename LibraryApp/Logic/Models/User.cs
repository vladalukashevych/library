namespace Logic.Models;

public partial class User
{
    public string NameForRecord
    {
        get => $"{Id} - {FirstName} {LastName}";
    }
}
