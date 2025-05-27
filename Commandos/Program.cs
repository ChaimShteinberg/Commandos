using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Commando myCommando = new Commando("Chaim", "kodcode");
            myCommando.Walk();
            myCommando.Hide();
            myCommando.Attack();
            Console.WriteLine(myCommando.SayName("GENERAL"));
            Console.WriteLine(myCommando.SayName("COLONEL"));
            Console.WriteLine(myCommando.SayName("CHAIM"));
            Console.WriteLine(myCommando.CodeName);
            myCommando.CodeName = "kodcode2";
            Console.WriteLine(myCommando.CodeName);

            Weapon myWeapon = new Weapon("Sidearm", "IDF", 1);
            myWeapon.Shoot();
            myWeapon.Shoot();
        }
    }
}