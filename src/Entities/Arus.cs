namespace RPG.src.Entities
{
    public class Heroi
    {
        public string name;
        public int level;
        public string heroType;

        public Heroi(string name, int level, string heroType){

            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string  ToString()
        {
            return this.name + " " + this.level + " " + this.heroType + "";
        }
        public virtual string Attack(){
            return this.name + "Atacou com sua espada";
        }

       }
    }
