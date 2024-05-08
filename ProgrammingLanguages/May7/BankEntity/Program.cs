using System;
using System.Collections.Generic;

namespace ConsoleApp1.May7.BankEntity;

public class Program
{
    static Dictionary<string, object> user1 = new Dictionary<string, object>()
    {
        {"Id", 1},
        {"Name", "John"},
        {"LastName", "Doe"},
        {"Birthday", new DateTime(1990, 1, 1)},
        {"Address", "123 Main St"}
    };

    static Dictionary<string, object> account1 = new Dictionary<string, object>()
    {
        {"Id", 1},
        {"Amount", 1000},
        {"Status", "Active"},
        {"Currency", "USD"},
    };

    static Dictionary<object, object> owners = new Dictionary<object, object>()
    {
        { account1["Id"], user1["Id"] },
    };
    
}
