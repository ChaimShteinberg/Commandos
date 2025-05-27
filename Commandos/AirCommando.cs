using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class AirCommando: Commando
    {
        public AirCommando(string name, string codeName):base (name, codeName)
        {
        }

        public void Parachute()
        {
            Console.WriteLine("The soldier parachutes");
        }
    }
}
