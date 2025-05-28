using Commandos.Models;

namespace Commandos.Services
{
    internal class NamePermissions
    {
        static string SayName(string rank, Commando soldier)
        {
            if (rank == "GENERAL")
            {
                return soldier.Name;
            }
            else if (rank == "COLONEL")
            {
                return soldier.CodeName;
            }
            else
            {
                return "Classified information";
            }
        }

    }
}
