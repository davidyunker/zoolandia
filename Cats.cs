
namespace Zoolandia 
{

    public class Cats: Animal {
        public string color  { get; set; }

        public string furType {get; set;}


          public Cats (string name)
            {
            this.name = name;
            }
        public override string description()
            {
                string message=string.Empty;

                {
                message=$"Your cat, {this.name}, is  {this.color} with {this.furType} fur. \n {base.description()} ";
    
                }
                return message; 
            }
    }

}
