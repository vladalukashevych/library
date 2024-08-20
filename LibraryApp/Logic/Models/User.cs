namespace Logic.Models;

public partial class User
{
    public string FullName
    {
        get => $"{FirstName} {LastName}";
    }
}
