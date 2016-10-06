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
                    var bird=new Birds
                    {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        wingspan=Convert.ToInt16(args[3]),
                        flightStyle=args[4]
                    };
                    Console.WriteLine(bird.description());
                } 
               if(animalType=="reptiles") 
                {
                    var reptile=new Reptiles 
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
                    var fishy=new Fish 
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
                    var cat=new Cats 
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
