
namespace Zoolandia 
{

    public class Magikarp: Species {

        public Magikarp () {
        this.genus = new Fish();  
        }
    
     public override string getSpeciesName()
        {
            return "Magikarp species";
        }

    }
}