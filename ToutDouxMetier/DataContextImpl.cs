using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutDouxMetier
{
    public class DataContextImpl : IDataContext
    {
        private List<ListeTaches> listeTaches=new();

        public void InitDummy()
        {
            listeTaches.Add(new ListeTaches("Boulot",
                "Cras justo odio",
                "Dapibus ac facilisis in",
                "Morbi leo risus",
                "Porta ac consectetur ac",
                "Vestibulum at eros",
                "Morbi leo risus"
            ));
            listeTaches.Add(new ListeTaches("Loisirs",
                "Cras justo odio",
                "Porta ac consectetur ac",
                "Vestibulum at eros",
                "Morbi leo risus"
            ));
            listeTaches.Add(new ListeTaches("Administratif",
                "Morbi leo risus",
                "Porta ac consectetur ac",
                "Vestibulum at eros"
            ));
            var rnd = new Random();
            foreach(Tache t in Taches)
            {
                if(rnd.Next(3)==0)
                {
                    t.Echeance = DateTime.Now.AddDays(rnd.Next(15)-5);
                }
            }
        }

        #region IDataContext implementation
        public IEnumerable<ListeTaches> Listes => listeTaches;

        public IEnumerable<Tache> Taches => listeTaches.SelectMany(liste => liste.Taches);

        public void Add(ListeTaches liste) => listeTaches.Add(liste);

        public void Remove(ListeTaches liste) => listeTaches.Remove(liste);
        #endregion
    }
}
