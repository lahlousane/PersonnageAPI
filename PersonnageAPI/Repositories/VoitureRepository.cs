using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnages.Repositories
{
    using Models;
    public interface VoitureRepository
    {
        public Voiture Save(Voiture v);
        public IEnumerable<Voiture> FindAll();
        public IEnumerable<Voiture> FindByID(int id);
        public Voiture UpDate(Voiture v);
        public void Delete(int id);
        public void Delete(Voiture v);
    }
}
