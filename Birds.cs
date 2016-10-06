

namespace Zoolandia 
{

    public class Birds: Animal {


        public Birds (string name)
            {
            this.name = name;
            }
         public Birds (int wingspan)
            {
            this.wingspan = wingspan;
            }

        public Birds (string name, int wingspan)
            {
            this.name = name;
            this.wingspan = wingspan;
            }
            // Add a new, overloaded constructor method to your animal that takes a single string as an argument.


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