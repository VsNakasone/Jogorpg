namespace Jogorpg.src.Entities
{
    public class Wands : Heroes
    {
       public Wands(string Name, int Level, string Element)
       {
           this.Name = Name;
           this.Level = Level;
           this.Element = Element;
       }
        public override string Attack()
        {
            return this.Name + " attack with Fire ";
        }
        public string Attack( int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " of " + this.Element + " Super effective fire attack " + Bonus ;
            }else {
                return this.Name + " of " + this.Element + " Weak fire attack " + Bonus ;
            }
        }
    }
}