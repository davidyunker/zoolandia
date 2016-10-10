using System;
using System.Collections.Generic;


namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
        Household galelane = new Household();
            galelane.public_name = "my house"; 
        Nests pokenest = new Nests();
            pokenest.public_name = "pokebox";
        FishTank thetank = new FishTank();
            thetank.public_name = "tanklanta"; 

      Zoo zoolandia = new Zoo();
      zoolandia.habitats.Add(galelane);
      zoolandia.habitats.Add(pokenest);
      zoolandia.habitats.Add(thetank);

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
        
        galelane.inhabitants.Add(animal1);
        galelane.inhabitants.Add(animal2);
        thetank.inhabitants.Add(animal3);
        thetank.inhabitants.Add(animal4);
        pokenest.inhabitants.Add(animal5);
        pokenest.inhabitants.Add(animal6);

     
        

        List<Animal> pets = new List<Animal>();
            pets.Add(animal1);
            pets.Add(animal2);
            pets.Add(animal3);
            pets.Add(animal4);
            pets.Add(animal5);
            pets.Add(animal6);

foreach(Habitat habitat in zoolandia.habitats)
      {
        Console.WriteLine($"\n{habitat.public_name}\nAnimals in this habitat:");
        foreach (Animal a in habitat.inhabitants)
        {
          Console.WriteLine($@"{a.name} the {a.species.getSpeciesName()} in the {a.species.genus.getGenus()}.");
        }
      }
  
        }
    }
}

