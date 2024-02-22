using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.DesignPatterns.Adapter;
public class LegacySqlDatabase
{
    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing old sql query:{query}");
    }
}
