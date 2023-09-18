using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User l1 = new User();
            l1.setName("Sidharth");
            Console.WriteLine(l1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "SAT";
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }

}
