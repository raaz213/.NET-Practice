using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class Account
    {
        public virtual int balance()
        {
            return 10;
        }
    }
    public class Amount : Account
    {
       public override int balance()
        {
            return 150;
        }
    }
    internal class overriding
    {
        static void Main(String[] args)
        {
            Account account = new Account();
           int balance =  account.balance();
            Console.WriteLine("Balance: " + balance);
        }
    }
}
