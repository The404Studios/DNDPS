public class User
{
    public Account Account { get; set; }
    public Character Character { get; set; }
    public Party Party { get; set; }
}

public class Account
{
    public string Username { get; set; }
    public int Id { get; set; }
}

public class Character
{
    public string Nickname { get; set; }
}

public class Party
{
    // Define party properties here.
}
