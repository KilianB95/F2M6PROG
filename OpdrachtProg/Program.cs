using System;


namespace OpdrachtProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            DragonList dragonList = new DragonList();
            

            Pokemon Zekrom = new Legendary("Zekrom", PokemonTypes.Electric);
            Pokemon Giratina = new Legendary("Giratina", PokemonTypes.Ghost);
            Pokemon Rayquaza = new Legendary ("Rayquaza", PokemonTypes.Flying);
            Pokemon Zygarde = new Legendary("Zygarde", PokemonTypes.Ground);


            dragonList.AddDragonTypes(Zekrom);
            dragonList.AddDragonTypes(Giratina);
            dragonList.AddDragonTypes(Rayquaza);
            dragonList.AddDragonTypes(Zygarde);
            
            foreach(Pokemon c in dragonList.GetPokemon())
            {
                Console.WriteLine(c.GetName());
                c.Use();
            }
            
        }
    }

  

    
}
