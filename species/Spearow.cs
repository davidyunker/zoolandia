namespace Zoolandia 
{

    public class Spearow: Birds {

            public Spearow () {
            this.name = "angry";
        }

        public Spearow (string name, int wingspan, string flightStyle) 
        {
            this.name = name;
            this.wingspan = wingspan;
            this.flightStyle = flightStyle;
        }
          public override string attackResponse() 
        {
            return $"I've got a lot of attack ready for you. I'm fierce! {base.attackResponse()}"; 
        }

    }

}