using Commandos.Models;

namespace Commandos.Services
{
    public class Walking
    {
        static void Walk(Commando soldier)
        {
            Console.WriteLine("The soldier is walking");
            soldier.status = Status.Walking;
        }
    }
}
