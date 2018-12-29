namespace Creational.Prototype.Standard
{
    public abstract class Prototype
    {
        public Prototype(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1: Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
