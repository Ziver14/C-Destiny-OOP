using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Alligator : Animal
    {
        public string name { get; set; }
        public Alligator(string name) : base(name) { }
        public override void Info()
        {

            Console.WriteLine("Alligator:");
            base.Info();
        }
    }
}
