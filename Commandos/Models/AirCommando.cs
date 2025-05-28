using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando: Commando
    {
        public AirCommando(string name, string codeName):base (name, codeName)
        {
        }

        public void Parachute()
        {
            Console.WriteLine("The soldier parachutes");
        }

        public override void Attack()
        {
            Console.WriteLine($"The Air Commando is attacking.");
        }
    }
}
