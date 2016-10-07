namespace Zoolandia 
{

    public class Pidgey : Birds {
        public Pidgey () {
            this.name = "tiny";
        }

        public Pidgey (string name, int wingspan, string flightStyle) 
        {
            this.name = name;
            this.wingspan = wingspan;
            this.flightStyle = flightStyle;
        }

          public override string attackResponse() 
        {
            return $"I'm mostly just irritating and I'm not very effective at attacking.\n {base.attackResponse()}"; 
        }
    }
}