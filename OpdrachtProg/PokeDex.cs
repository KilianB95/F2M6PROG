using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OpdrachtProg
{
    class Pokemon
    {
        private string name;

        public Pokemon(string Name)
        {
            name = Name;
        }
        public string GetName()
        {
            return name;
        }
        
    }
}
