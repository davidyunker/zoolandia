namespace Zoolandia 
{

    public class Pidgey: Species {

        public Pidgey () {
        this.genus = new Birds();  
        }
    
     public override string getSpeciesName()
        {
            return "Birds species";
        }

    }
}