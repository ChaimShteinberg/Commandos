namespace Commandos.Models
{
    internal class Commando
    {
        internal string Name;
        internal string CodeName { get; set; }
        internal string[] Weapons { get; } = { "Hammer", "chisel", "rope", "bag", "water bottle" };
        internal Status status = Status.Standing;

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
        }

        //public string SayName(string commanderRank)
        //{
        //    if (commanderRank == "GENERAL")
        //    {
        //        return Name;
        //    }
        //    else if (commanderRank == "COLONEL")
        //    {
        //        return CodeName;
        //    }
        //    else
        //    {
        //        return "Classified information";
        //    }
        //}

        //public void Walk()
        //{
        //    Console.WriteLine("The soldier is walking");
        //    status = Status.Walking;
        //}

        //public void Hide()
        //{
        //    Console.WriteLine("The soldier is hiding");
        //    status = Status.Hiding;
        //}

        public virtual void Attack()
        {
            Console.WriteLine($"The commando with codeName {CodeName} is attacking.");
        }        
    }
}
