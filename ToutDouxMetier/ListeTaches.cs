using System.Text;

namespace ToutDouxMetier
{
    /// <summary>
    /// Gère une liste de tâches de type "to-do"
    /// </summary>
    public class ListeTaches
    {
        private Dictionary<Guid, Tache> listeTaches = new ();

        public ListeTaches(string nom, params string [] intituleTaches)
        {
            Nom = nom;
            foreach(string intitule in intituleTaches)
            {
                Add(intitule);
            }
        }
        public string Nom { get; set; }
        public Tache Add(string intitule)
        {
            var tache = new Tache(intitule);

            listeTaches.Add(tache.Id, tache);
            return tache;
        }
        
        public void TriggerDone(Guid id)
        {
            listeTaches[id].Fait = !listeTaches[id].Fait;
        }

        public void Remove(Guid id)
        {
            listeTaches.Remove(id);
        }

        public IEnumerable<Tache> Taches => listeTaches.Values;

        public override bool Equals(object? obj) => Nom == (obj as ListeTaches)?.Nom;

        public override int GetHashCode() => Nom.GetHashCode();

        /*public override bool Equals(object? obj)
        {
            var other = obj as ListeTaches;

            return Nom == other?.Nom && Taches.SequenceEqual(other.Taches);
        }

        public override int GetHashCode()
        {
            StringBuilder sb = new(Nom);

            foreach(var tache in Taches)
            {
                sb.Append($", {tache.Id}");
            }
            return sb.ToString().GetHashCode();
        }*/
    }
}
