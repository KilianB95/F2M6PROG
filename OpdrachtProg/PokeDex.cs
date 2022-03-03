using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OpdrachtProg
{
    public enum PokemonTypes
    {
        Electric,
        Ghost,
        Flying,
        Ground,
    }
    abstract class Pokemon
    {
       

        public string name { get; private set; }
        public PokemonTypes Types { get; private set; }

        

        protected Pokemon(string Name, PokemonTypes types)
        {
            name = Name;
            Types = types;
           
        }
        public string GetName()
        {
            return name;
        }
        public abstract void Use();

        

    }
}
