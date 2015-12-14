using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.deposit(200);
            acc.withdraw(100);
        }
    }
}
