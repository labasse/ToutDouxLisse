namespace ToutDouxMetier
{
    public interface IDataContext
    {
        void Add(ListeTaches liste);
        void Remove(ListeTaches liste);
        IEnumerable<ListeTaches> Listes { get; }

        IEnumerable<Tache> Taches { get; }
    }
}
