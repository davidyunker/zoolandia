

namespace Zoolandia 
{

    public class Birds: Genus {
        public override string getGenus ()
        {
            return "Bird genus";
        }
          
        public virtual string attackResponse() 
        {
            return "Birds will attack when necessary."; 
        }
       

    }

}