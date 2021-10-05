namespace Alebrije.Abstractions.Patterns
{
    public interface IFactory<out TService>
    {
        TService Create();
        TService Create(string name);
    }
}