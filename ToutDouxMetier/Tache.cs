namespace ToutDouxMetier
{
    /// <summary>
    /// Une tâche de liste "to-do"
    /// </summary>
    public class Tache
    {
        public Tache(int id, string intitule)
        {
            Id = id;
            Intitule = intitule;
        }
        public int Id { get; private init; }
        public bool Fait { get; set; }
        public string Intitule { get; set; }
    }
}