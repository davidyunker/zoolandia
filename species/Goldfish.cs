
namespace Zoolandia 
{

    public class Goldfish: Species {

        public Goldfish () {
        this.genus = new Fish();  
        }
    
     public override string getSpeciesName()
        {
            return "Goldfish species";
        }

    }
}