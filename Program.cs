using System;
using System.Collections.Generic;


namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
         Animal animal1 = new Animal();
            animal1.species = new Renly();
            animal1.name = "Renbear";
            animal1.weight = 15;  
        
         Animal animal2 = new Animal();
            animal2.species = new Ophelia();
            animal2.name = "Baby kitty";
            animal2.weight = 9;

         Animal animal3 = new Animal();
            animal3.species = new Goldfish();
            animal3.name = "Goldeen";
            animal3.weight = 2;  
         
         Animal animal4 = new Animal();
            animal4.species = new Magikarp();
            animal4.name = "Floppy";
            animal4.weight = 2;  
        
         Animal animal5 = new Animal();
            animal5.species = new Spearow();
            animal5.name = "Angry";
            animal5.weight = 30;
         
         Animal animal6 = new Animal();
            animal6.species = new Pidgey();
            animal6.name = "Twitchy";
            animal6.weight = 7;    
        

        List<Animal> pets = new List<Animal>();
            pets.Add(animal1);
            pets.Add(animal2);
            pets.Add(animal3);
            pets.Add(animal4);
            pets.Add(animal5);
            pets.Add(animal6);

            foreach (Animal animal in pets)
            {
            Console.WriteLine($"Your new {animal.species.getSpeciesName()}, {animal.name}, is {animal.weight}LBs, a member of the {animal.species.genus.getGenus()}");
            }
        }
    }
}
