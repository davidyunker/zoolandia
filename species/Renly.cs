using System; 
namespace Zoolandia 
{

    public class Renly: Cats {

        public int meows { get; set; }

     
        public Renly () {
        this.name = "cuddlehead";  
        }

        public Renly (string name, string eat, int weight) { 
            this.name= name; 
            this.eat= eat; 
            this.weight = weight; 
        }
           public override string description()
            {
                string message=string.Empty;

                {
                message=$"Your Renly, {this.name}, has {this.meows} meows in his arsenal. He weighs {this.weight} pounds.\n {base.description()} ";
    
                }
                return message; 
            }

              public void nap(int hours) 
        {
         Console.WriteLine($"I had a nap for {hours} hours");
  
        }
        public void nap(int hours, string location) 
        {
        Console.WriteLine($"My nap for {hours} hours on the {location} was amazing.");

        }

             public override string destroys()
        {
          return "I love to tear up furniture. It's the first task of Renly's demo crew. The following is a lie. \n {base.destroys()}";  
        }

    }

}