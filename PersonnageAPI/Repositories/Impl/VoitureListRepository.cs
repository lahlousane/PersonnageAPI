using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnages.Repositories.Implementation
{
    using Models;

    public class VoitureListRepository : VoitureRepository
    {
        private List<Voiture> voitures = new List<Voiture>();
        public void Delete(int id)
        {
            this.voitures[id] = null;
        }

        public void Delete(Voiture v)
        {
            this.voitures[v.Id] = null;
        }

        public IEnumerable<Voiture> FindAll()
        {
            return this.voitures.Where(v => v != null);
        }

        public IEnumerable<Voiture> FindByID(int id)
        {
            return voitures.Where(v => v.Id == id);
        }

        public Voiture Save(Voiture v)
        {
            v.Id = this.voitures.Count();
            this.voitures.Add(v);
            return v;
        }

        public Voiture UpDate(Voiture v)
        {
            this.voitures[v.Id] = v;
            return v;
        }
    }
}
