using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
       
       public string name{  get; set; }
       
       public Animal (string name ){
            
            this.name = name;
        }
        public virtual void Info() {
            Console.WriteLine($"{name}");
           
        }
    }
            

}
        

        
        
