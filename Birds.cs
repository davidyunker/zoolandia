

namespace Zoolandia 
{

    public class Birds: Animal {


        public Birds ()
            {
            this.name = "Pidgey";
            }

        public int wingspan  { get; set; }

        public string flightStyle {get; set;}

        
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