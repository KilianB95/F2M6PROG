using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtProg
{
    class Legendary : Pokemon
    {
      
        public Legendary(string name, PokemonTypes types) : base(name, types)
        {

        }
        public override void Use()
        {
            
            Console.WriteLine("This Pokemon is : " + name + " Type : " + Types);
        }
    }
}
