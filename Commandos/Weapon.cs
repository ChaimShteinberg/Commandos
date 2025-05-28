namespace Commandos
{
    internal class Weapon
    {
        private string Name;
        private string Facturer;
        private int Bullets;

        public Weapon(string name, string facturer, int bullets)
        {
            this.Name = name;
            this.Facturer = facturer;
            this.Bullets = bullets;
        }

        public void Shoot()
        {
            if (this.Bullets > 0)
            {
                Console.WriteLine("shot");
                this.Bullets--;
            }
            else
            {
                Console.WriteLine("You don't have a ball.");
            }
        }
    }    
}
