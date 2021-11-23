using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OpdrachtProg
{
    class DragonList
    {
        private List<Pokemon> _pokemon;

       public DragonList()
        {
            _pokemon = new List<Pokemon>();
        } 
       

       public void AddDragonTypes(Pokemon pokemon)
       {
            _pokemon.Add(pokemon);
            
       }

        public List<Pokemon> GetPokemon()
        {
            return _pokemon;
        }
        
    }
}
