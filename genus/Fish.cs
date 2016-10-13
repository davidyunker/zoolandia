

namespace Zoolandia 
{

    public class Fish: Genus, IFish {
        public override string getGenus ()
        {
            return "Fish genus";
        }
        public string swims()
        {
          return "Fish typically enjoy swimming.";  
        }

      
    }

}
