

namespace Zoolandia 
{

    public class Cats: Genus, ICat {
        public override string getGenus ()
        {
            return "Cats genus";
        }

        public override string kittyVoice ()
        {
            return "Meow wow wow wow"; 
        }

        public int claws{get;set;}
    }
}