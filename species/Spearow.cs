namespace Zoolandia 
{

    public class Spearow: Species {

        public Spearow () {
        this.genus = new Birds();  
        }
    
     public override string getSpeciesName()
        {
            return "Birds species";
        }

    }
}