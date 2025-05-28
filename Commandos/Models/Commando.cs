using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Enums;

namespace Commandos
{
    internal class Commando
    {
        protected string Name;
        public string CodeName { get; set; }
        public string[] Weapons = { "Hammer", "chisel", "rope", "bag", "water bottle" };
        private Status status = Status.Standing;

        public Commando(string name, string codeName)
        {
            this.Name = name;
            this.CodeName = codeName;
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                return this.Name;
            }
            else if (commanderRank == "COLONEL")
            {
                return this.CodeName;
            }
            else
            {
                return "Classified information";
            }
        }

        public void Walk()
        {
            Console.WriteLine("The soldier is walking");
            this.status = Status.Walking;
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hiding");
            this.status = Status.Hiding;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"The commando with codeName {this.CodeName} is attacking.");
        }        
    }
}
