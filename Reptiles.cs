

namespace Zoolandia 
{

    public class Reptiles: Animal {
        public string scaleTexture  { get; set; }

    

      public override string description()
        {
            string message=string.Empty;

            {
            message=$"Your reptile, ${this.name}, has a ${this.scaleTexture}\n {base.description()} ";
 
            }
            return message; 
        }
    }
}

