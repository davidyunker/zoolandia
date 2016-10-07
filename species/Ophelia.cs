using System; 

namespace Zoolandia 
{

    public class Ophelia : Cats {

        public int jumps {get; set;}
        

        // public Ophelia () {
        // this.name = "Lady O";  
        // }

        // public Ophelia () {
        // this.eat = "wet foods";
        // }
        public Ophelia (string name, string eat, int weight) { 
            this.name= name; 
            this.eat= eat; 
            this.weight = weight; 
        }

        public void sleep(int hours) 
        {
         Console.WriteLine($"I had a sleep for {hours} hours");
  
        }
        public void sleep(int hours, string location) 
        {
        Console.WriteLine($"My sleep for {hours} hours on the {location} was amazing.");

        }
           public override string description()
            {
                string message=string.Empty;

                {
                message=$"Your Ophelia, {this.name}, jumps to areas {this.jumps} feet in the air. She weighs {this.weight} pounds.\n {base.description()} ";
    
                }
                return message; 
            }
        
        public override string destroys()
        {
          return $"I love to tear up paper. Toilet paper is my favorite. The following is what Renly says. \n {base.destroys()}";  
        }


    }

}