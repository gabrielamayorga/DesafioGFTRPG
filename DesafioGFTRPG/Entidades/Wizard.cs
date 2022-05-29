namespace DesafioGFTRPG
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou uma magia!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou uma magia SUPER EFETIVA com bonus de" + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia fraca com bonus de" + Bonus;
            }
        }
    }
}