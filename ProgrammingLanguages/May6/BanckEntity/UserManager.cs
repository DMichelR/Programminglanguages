namespace ConsoleApp1.May6.BanckEntity;

public class UserManager
{
    private Dictionary<int, List<Account>> _userAccounts = new Dictionary<int, List<Account>>();

    public User CreateUser(int id, string name, string lastName, DateTime birthday, string address)
    {
        User user = new User(id, name, lastName, birthday, address);
        _userAccounts[id] = new List<Account>();
        return user;
    }

    public Account CreateAccount(int id, decimal amount, string status, string currency, int userId)
    {
        Account account = new Account(id, amount, status, currency);
        if (_userAccounts.ContainsKey(userId))
        {
            _userAccounts[userId].Add(account);
        }
        else
        {
            throw new Exception("User does not exist.");
        }
        return account;
    }

    public List<Account> GetUserAccounts(int userId)
    {
        if (_userAccounts.ContainsKey(userId))
        {
            return _userAccounts[userId];
        }
        else
        {
            throw new Exception("User does not exist.");
        }
    }
}