namespace RPG.src.Entities
{
    public class Knight : Heroi
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
    }
}