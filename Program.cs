using System;

namespace Zoolandia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animalType= args[0];

             if(animalType=="birds") 
                {
                    // Birds bird=new Birds("Pidgey")
                    // {
                    //     // name=args[1],
                    //     height=Convert.ToInt16(args[1]),
                    //     weight=Convert.ToInt16(args[2]),
                    //     wingspan=Convert.ToInt16(args[3]),
                    //     flightStyle=args[4]
                    // };
                    // Console.WriteLine(bird.description());
                    Birds newbird=new Birds("pidgey", 8)
                       {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        flightStyle=args[3]
                    };
                    Console.WriteLine(newbird.description());

                } 
               if(animalType=="reptiles") 
                {
                    Reptiles reptile=new Reptiles("Slimey") 
                    {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        scaleTexture=args[3]
                        
                    };
                    Console.WriteLine(reptile.description());
                } 

                if(animalType=="fish") 
                {
                    Fish fishy=new Fish("Seaking") 
                    {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        fins=Convert.ToInt16(args[3]),
                        size=args[4]
                        
                    };
                    Console.WriteLine(fishy.description());
                } 

                if(animalType=="cats") 
                {
                    Cats cat=new Cats("Renbear") 
                    {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        color=args[3],
                        furType=args[4]
                        
                    };
                    Console.WriteLine(cat.description());
                } 

        }
    }
}
