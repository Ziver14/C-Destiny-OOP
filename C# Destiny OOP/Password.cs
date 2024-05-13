using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Destiny_OOP
{
    public class Password
    {
        public int serrial {  get; set; }
        public string name {  get; set; }

       public Password(int serrial, string name)
        {
            this.serrial = serrial;
            this.name = name;
        }

        public void Info()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{serrial}");

        }
    }
}
