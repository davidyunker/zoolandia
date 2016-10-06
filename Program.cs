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
                        name=args[1],
                        height=Convert.ToInt16(args[2]),
                        weight=Convert.ToInt16(args[3]),
                        wingspan=Convert.ToInt16(args[4]),
                        flightStyle=args[5]
                    };
                    Console.WriteLine(bird.description());
                } 
               if(animalType=="reptiles") 
                {
                    var reptile=new Reptiles 
                    {
                        name=args[1],
                        height=Convert.ToInt16(args[2]),
                        weight=Convert.ToInt16(args[3]),
                        scaleTexture=args[4]
                        
                    };
                    Console.WriteLine(reptile.description());
                } 

                if(animalType=="fish") 
                {
                    var fishy=new Fish 
                    {
                        name=args[1],
                        height=Convert.ToInt16(args[2]),
                        weight=Convert.ToInt16(args[3]),
                        fins=Convert.ToInt16(args[4]),
                        size=args[5]
                        
                    };
                    Console.WriteLine(fishy.description());
                } 

                if(animalType=="cats") 
                {
                    var cat=new Cats 
                    {
                        name=args[1],
                        height=Convert.ToInt16(args[2]),
                        weight=Convert.ToInt16(args[3]),
                        color=args[4],
                        furType=args[5]
                        
                    };
                    Console.WriteLine(cat.description());
                } 

        }
    }
}
