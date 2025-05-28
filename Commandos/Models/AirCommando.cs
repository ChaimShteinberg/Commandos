namespace Commandos.Models
{
    internal class AirCommando: Commando
    {
        public AirCommando(string name, string codeName):base (name, codeName)
        {
        }

        static void Parachute()
        {
            Console.WriteLine("The soldier parachutes");
        }

        public override void Attack()
        {
            Console.WriteLine($"The Air Commando is attacking.");
        }
    }
}
