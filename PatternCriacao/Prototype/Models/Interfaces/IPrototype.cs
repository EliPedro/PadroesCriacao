namespace Prototype.Models.Interfaces
{
    public interface IPrototype<T> where T: class
    {
        T Clone();
    }
}
