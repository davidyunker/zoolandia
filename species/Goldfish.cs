using System; 
namespace Zoolandia 
{

    public class Goldfish: Fish {

        public Goldfish () {
        this.name = "goldeen";  
        }

        public Goldfish (string name, int fins, string size) { 
            this.name= name; 
            this.fins= fins; 
            this.size = size; 
        }
        public string memory {get;set;}

         public override string swims()
        {
          return $"I swim the tankly many times a day. {base.swims()}";  
        }
      public override string description()
            {
                string message=string.Empty;

                {
                message=$"Your goldfish, {this.name}, memory is {this.memory}. It weighs {this.weight} pounds.\n {base.description()} ";
    
                }
                return message; 
            }
    }
}