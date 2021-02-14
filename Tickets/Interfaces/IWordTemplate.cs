namespace Tickets.Interfaces
{
    public interface IWordTemplate<TSection> where TSection : class
    {
        void Execute(TSection section);
    }
}
