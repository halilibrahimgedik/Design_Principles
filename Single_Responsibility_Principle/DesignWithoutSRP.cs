using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_WithoutSRP;

class Database
{
    public void Connect()
    {
        //...
    }

    public void DisConnect()
    {
        //...
    }

    public List<User> GetUsers()
    {
        //........
        return new List<User>()
        {
            new User() {Id=1,Name="Halil"},
            new User() {Id=1,Name="Ahmet"},
            new User() {Id=1,Name="Mehmet"},
        };
    }
}

class User
{
    public int Id { get; set; }

    public string Name { get; set; }

    //.......
}



