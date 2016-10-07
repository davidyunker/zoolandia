

namespace Zoolandia 
{

    public class Birds: Animal {

          
        public int wingspan  { get; set; }

        public string flightStyle {get; set;}

        public virtual string attackResponse() 
        {
            return "Birds will attack when necessary."; 
        }
        public override string description()
        {
            string message=string.Empty;

            {
            message=$"Your bird, {this.name}, has a {this.wingspan} wingspan and a flight style of {this.flightStyle}\n {base.description()} ";
 
            }
            return message; 
        }

    }

}