using System;


namespace OpdrachtProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            DragonList dragonList = new DragonList();
            
            Pokemon Zekrom = new Legendary("Zekrom");
            Pokemon Giratina = new Legendary("Giratina");
            Pokemon Rayquaza = new Legendary ("Rayquaza");
            Pokemon Zygarde = new Legendary("Zygarde");


            dragonList.AddDragonTypes(Zekrom);
            dragonList.AddDragonTypes(Giratina);
            dragonList.AddDragonTypes(Rayquaza);
            dragonList.AddDragonTypes(Zygarde);
            
            foreach(Pokemon c in dragonList.GetPokemon())
            {
                //Console.WriteLine(c.GetName());
                c.Use();
            }
            
        }
    }

  

    
}
