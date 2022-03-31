namespace RPG.src.Entities
{
    public class Wizard : Heroi
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack(){
            return this.name + "Lançou Magia";
        
    }
  }
}