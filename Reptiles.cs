

namespace Zoolandia 
{

    public class Reptiles: Animal {
        public string scaleTexture  { get; set; }

    public Reptiles (string name)
            {
            this.name = name;
            }

      public override string description()
        {

        
            string message=string.Empty;

            {
            message=$"Your reptile, {this.name}, has a {this.scaleTexture} texture \n {base.description()} ";
 
            }
            return message; 
        }
    }
}

