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
                    Cats cat=new Cats  
                    {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        color=args[3],
                        furType=args[4]
                        
                    };
                    Console.WriteLine(cat.description());
                } 


                if(animalType=="renly") 
                { 

                    Renly renbear=new Renly("snugglehead", "wetfood", 15)
                    {
                        // name=args[0], 
                        height=Convert.ToInt16(args[1]),
                        color=args[2],
                        furType=args[3],
                        meows=Convert.ToInt16(args[4])
                    };

                    Console.WriteLine(renbear.description());
                }

                    if(animalType=="ophelia") 
                { 

                    Ophelia babykitty=new Ophelia("Lady O", "wetfoods", 9)
                    {
                        // name=args[0], 
                        height=Convert.ToInt16(args[1]),
                        color=args[2],
                        furType=args[3],
                        jumps=Convert.ToInt16(args[4])
                    };
                    Console.WriteLine(babykitty.destroys());
                    Console.WriteLine(babykitty.description());
                    babykitty.sleep(8, "stoop");
                    babykitty.sleep(10);
                }

        }
    }
}
