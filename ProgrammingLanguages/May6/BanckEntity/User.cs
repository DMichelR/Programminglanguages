namespace ConsoleApp1.May6.BanckEntity;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Address { get; set; }
    
    public User(int id, string name, string lastName, DateTime birthday, string address)
    {
        Id = id;
        Name = name;
        this.LastName = lastName;
        this.Birthday = birthday;
        this.Address = address;
    }
}