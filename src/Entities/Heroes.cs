namespace Jogorpg.src.Entities;

public abstract class Heroes
{
    public Heroes(string Name, int Level, string Element)
    {
        this.Name = Name;
        this.Level = Level;
        this.Element = Element;
    }
    
    public Heroes(){

    }
    public string Name;

    public int Level;

    public string Element;

    public override string ToString()
    {
        return this.Name + " " + this.Level+ " "+ this.Element;
    }

    public virtual string Attack()
    {
        return this.Name + " atacou com a sua espada";
    }
}
