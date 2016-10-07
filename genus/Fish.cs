

namespace Zoolandia 
{

    public class Fish: Animal {
        public int fins  { get; set; }

        public string size {get; set;}

        public virtual string swims()
        {
          return "Fish typically enjoy swimming.";  
        }

        public override string description()
        {
            string message=string.Empty;

            {
            message=$"Your fish, {this.name}, has  {this.fins} fins and is {this.size}\n {base.description()} ";
 
            }
            return message; 
        }
    }

}
