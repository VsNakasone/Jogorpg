namespace Jogorpg.src.Entities
{
    public class Pentacles : Heroes
    {
        public Pentacles(string Name, int Level, string Element)
        {
            this.Name = Name;
            this.Level = Level;
            this.Element = Element;
        }
       public override string Attack()
       {
           return this.Name + " attack with sand storm";
       }
       public string Attack(int Bonus)
       {
           if (Bonus > 6){
               return this.Name + " of " + this.Element + " Super effective sand storm attack " + Bonus ;
           }else{
               return this.Name + " of " + this.Element + " Weak sand storm attack " + Bonus ;
           }
       }
  
    }
}