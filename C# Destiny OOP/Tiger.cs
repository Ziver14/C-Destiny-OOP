using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiger : Animal
    {
        public string name { get; set; }
        public Tiger(string name) : base(name) { }
        public override void Info()
        {
       
            Console.WriteLine("Tiger:");
            base.Info();
        }

    }
}
        

