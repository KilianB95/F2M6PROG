using System;


namespace OpdrachtProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            DragonList dragonList = new DragonList();
            
            Pokemon Flygon = new Pokemon("Flygon");
            Pokemon Dratini = new Pokemon("Dratini");
            Pokemon Charizard = new Pokemon("Charizard");
            Pokemon Zygarde = new Pokemon("Zygarde");


            dragonList.AddDragonTypes(Flygon);
            dragonList.AddDragonTypes(Dratini);
            dragonList.AddDragonTypes(Charizard);
            dragonList.AddDragonTypes(Zygarde);
            
            foreach(Pokemon c in dragonList.GetPokemon())
            {
                Console.WriteLine(c.GetName());
                
                
            }
            
        }
    }

  

    
}
