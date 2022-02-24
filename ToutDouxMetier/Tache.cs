namespace ToutDouxMetier
{
    /// <summary>
    /// Une tâche de liste "to-do"
    /// </summary>
    public class Tache
    {
        public Tache(string intitule)
        {
            Id = Guid.NewGuid();
            Intitule = intitule;
        }
        public Guid Id { get; private init; }
        public bool Fait { get; set; }
        public string Intitule { get; set; }
        public DateTime? Echeance { get; set; } = null;
    }
}