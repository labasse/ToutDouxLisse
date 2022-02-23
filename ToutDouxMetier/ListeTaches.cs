namespace ToutDouxMetier
{
    /// <summary>
    /// Gère une liste de tâches de type "to-do"
    /// </summary>
    public class ListeTaches
    {
        private int id = 0;
        private Dictionary<int, Tache> listeTaches = new Dictionary<int, Tache>();

        public ListeTaches(params string [] intituleTaches)
        {
            foreach(string intitule in intituleTaches)
            {
                Add(intitule);
            }
        }
        public void Add(string intitule)
        {
            var tache = new Tache(++id, intitule);

            listeTaches.Add(tache.Id, tache);
        }
        
        public void TriggerDone(int id)
        {
            listeTaches[id].Fait = !listeTaches[id].Fait;
        }

        public void Remove(int id)
        {
            listeTaches.Remove(id);
        }

        public IEnumerable<Tache> Taches => listeTaches.Values;
    }
}
