namespace Jogorpg.src.Entities
{
    public class Swords : Heroes
    {
        public Swords(string Name, int Level, string Element)
        {
            this.Name = Name;
            this.Level = Level;
            this.Element = Element;
        }
        public override string Attack()
        {
            return this.Name + " Attack with hurricane";
        }
        public string Attack ( int Bonus)
        {
            if ( Bonus > 6 ){
                return this.Name + " of " + this.Element + " Super hurricane attack " + Bonus ;
                }else{
                    return this.Name + " of " + this.Element + " Weak hurricane attack " + Bonus ;
                }            
        }
    }
}