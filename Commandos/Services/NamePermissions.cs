using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Commandos.Soldiers;

namespace Commandos.Permissions
{
    internal class NamePermissions
    {
        public string SayName(string rank, Commando soldier)
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
