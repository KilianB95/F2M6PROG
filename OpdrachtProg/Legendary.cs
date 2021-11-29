using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtProg
{
    class Legendary : Pokemon
    {
       public Legendary(string name) : base(name)
        {

        }
        public override void Use()
        {
            Console.WriteLine("I CHOOSE U !!!!:" + name);
        }
    }
}
