namespace Commandos.Models
{
    internal class SeaCommando: Commando
    {
        public SeaCommando(string name, string codeName): base (name, codeName)
        {
        }

        static void Swim()
        {
            Console.WriteLine("The soldier swims");
        }

        public override void Attack()
        {
            Console.WriteLine($"The Sea Commando is attacking.");
        }
    }
}
