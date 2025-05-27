using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Commandos
    {
        private string Name;
        private string CodeName;
        private string[] Weapons = { "Hammer", "chisel", "rope", "bag", "water bottle" };
        private Status status = Status.Standing;

        public Commandos(string name, string codeName)
        {
            this.Name = name;
            this.CodeName = codeName;
        }

        public void Walk()
        {
            Console.WriteLine("The soldier is walking");
            this.status = Status.walking;
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hiding");
            this.status = Status.hiding;
        }

        public void Attack()
        {
            Console.WriteLine($"The commando 'wiht codeName {this.CodeName} is attacking.");
        }

        public enum Status
        {
            Standing, 
            walking, 
            hiding
        }
    }
}
