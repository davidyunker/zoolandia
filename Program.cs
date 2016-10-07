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
                   
                    Birds newbird=new Birds
                       {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        flightStyle=args[3]
                    };
                    Console.WriteLine(newbird.description());

                } 

                 if(animalType=="pidgey") 
                {
                   
                    Pidgey newpidge=new Pidgey("shawty", 4, "grounded")
                       {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        flightStyle=args[3]
                    };
                    Console.WriteLine(newpidge.description());
                    Console.WriteLine(newpidge.attackResponse());


                } 
            
                      if(animalType=="spearow") 
                {
                   
                    Spearow newspear=new Spearow("Gerald", 10, "sporadic")
                       {
                        // name=args[1],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        flightStyle=args[3]
                    };
                    Console.WriteLine(newspear.description());
                    Console.WriteLine(newspear.attackResponse());


                } 
                if(animalType=="fish") 
                {
                    Fish fishy=new Fish 
                    {
                        name=args[0],
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        fins=Convert.ToInt16(args[3]),
                        size=args[4]
                        
                    };
                    Console.WriteLine(fishy.description());
                } 
                
                    if(animalType=="goldfish") 
                {
                    Goldfish goldeen=new Goldfish("goldeen", 4, "medium") 
                    {
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        memory=args[3]
                        
                    };
                    Console.WriteLine(goldeen.description());
                    Console.WriteLine(goldeen.swims());

                } 

                    if(animalType=="magikarp") 
                {
                    Magikarp magi=new Magikarp("floppy", 4, "medium") 
                    {
                        height=Convert.ToInt16(args[1]),
                        weight=Convert.ToInt16(args[2]),
                        flops=Convert.ToInt16(args[3])
                        
                    };
                    Console.WriteLine(magi.description());
                    Console.WriteLine(magi.swims());

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

                    Renly renbear=new Renly("cuddlehead", "wetfood", 15)
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
