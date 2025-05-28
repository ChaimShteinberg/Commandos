using Commandos.Models;

namespace Commandos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Commando myCommando = new Commando("Chaim", "kodcode");
            AirCommando myAirCommando = new AirCommando("mendy", "big");
            SeaCommando mySeaCommando = new SeaCommando("meir", "small");

            Commando[] myCommandos = { myCommando, myAirCommando, mySeaCommando };

            foreach (Commando c in myCommandos)
            {
                c.Attack();
            }
        }
    }
}