using Commandos.Models;

namespace Commandos.Services
{
    internal class Hiding
    {
        static void Hide(Commando soldier)
        {
            Console.WriteLine("The soldier is hiding");
            soldier.status = Status.Hiding;
        }
    }
}
