using System; 
namespace Zoolandia 
{

    public class Magikarp: Fish {
        public Magikarp () {
        this.name = "flappy";  
        }

        public Magikarp (string name, int fins, string size) { 
            this.name= name; 
            this.fins= fins; 
            this.size = size; 
        }
        public int flops {get; set;}

          public override string swims()
        {
          return $"I can't swim. I only flop. {base.swims()}";  
        }

         public override string description()
            {
                string message=string.Empty;

                {
                message=$"Your magikarp, {this.name}, flops {this.flops} time a minute. It weighs {this.weight} pounds.\n {base.description()} ";
    
                }
                return message; 
            }
    }
}