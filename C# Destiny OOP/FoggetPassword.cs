using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Destiny_OOP
{
    public class FoggetPasword:Password
    {
        public int serrial {  get; set; }
        public string name {  get; set; }
        public string visa {  get; set; }

        public FoggetPasword(int serrial, string name) : base(serrial, name) { }

        

        public void Info()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{serrial}");
            Console.WriteLine($"{visa}");

        }


    }
}
