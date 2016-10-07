
namespace Zoolandia 
{


//  Include several methods on your Animal and/or genus classes that can be overridden and then override them in your species classes.
    public class Cats: Animal {
        public string color  { get; set; }
        public string furType {get; set;}
        public string eat { get; set; }

        //   public Cats (string name)
        //     {
        //     this.name = name;
        //     }

        public virtual string destroys()
        {
          return "I might tear something up. I'm not sure what it will be.";   
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
