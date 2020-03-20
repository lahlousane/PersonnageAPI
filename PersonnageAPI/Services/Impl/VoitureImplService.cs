using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnages.Services.Impl
{
    using Personnages.Models;
    using Repositories;
    public class VoitureImplService : VoitureService
    {
        private VoitureRepository repository;

        public VoitureImplService(VoitureRepository repository)
        {
            this.repository = repository;
        }
        public Voiture Modifier(Voiture v)
        {
            return this.repository.UpDate(v);
        }

        public Voiture Save(Voiture v)
        {
            return this.repository.Save(v);
        }

        public void Supprimer(int id)
        {
            this.repository.Delete(id);
        }

        public IEnumerable<Voiture> TrouverTout()
        {
            return this.repository.FindAll();
        }

        public Voiture TrouverUn(int id)
        {
            return this.repository.FindByID(id);
        }
    }
}
