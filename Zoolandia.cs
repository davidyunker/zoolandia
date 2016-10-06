using System;

namespace Zoolandia  
{


        public class Animal
    {
        public string name { get; set; }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

        public int height {get; set;}
        public int weight{get; set;}

            public virtual string description() 
                {
                return $"{this.name} has a height of {this.height} feet and weight of {this.weight} pounds. "; 
                }
    }

}
