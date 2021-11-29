using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OpdrachtProg
{
    abstract class Pokemon
    {
        
        public string name { get; private set; }

        protected Pokemon(string Name)
        {
            name = Name;
           
        }
        public string GetName()
        {
            return name;
        }
        public abstract void Use();
    }
}
