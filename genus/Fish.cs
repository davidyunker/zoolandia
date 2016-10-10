

namespace Zoolandia 
{

    public class Fish: Genus {
        public override string getGenus ()
        {
            return "Fish genus";
        }
        public virtual string swims()
        {
          return "Fish typically enjoy swimming.";  
        }

      
    }

}
