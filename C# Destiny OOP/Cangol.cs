using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cangol:Animal
    {
        public string name { get; set; }
        public Cangol(string name) : base(name) { }
        public override void Info()
        {

            Console.WriteLine("Cangol:");
            base.Info();
        }
    }
}
