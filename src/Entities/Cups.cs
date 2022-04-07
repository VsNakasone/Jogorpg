namespace Jogorpg.src.Entities
{
    public class Cups : Heroes
    {
        public Cups(string Name, int Level, string Element)
        {
            this.Name = Name;
            this.Level = Level;
            this.Element = Element;
        }
        public override string Attack()
        {
            return this.Name +  " attack with deluge of water ";
        }
        public string Attack( int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " of "+ this.Element + " Super deluge of water attack " + Bonus ;
            }else{
                return this.Name + " of " + this.Element + " Weak deluge of water attack " + Bonus ;
            }
        }
       
    }
}