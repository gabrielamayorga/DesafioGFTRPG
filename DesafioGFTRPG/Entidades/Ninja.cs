namespace DesafioGFTRPG
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " arremessou uma Adaga!";
        }
    }
}