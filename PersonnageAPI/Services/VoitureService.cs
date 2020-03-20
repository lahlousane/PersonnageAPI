using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnages.Services
{
    using Models;
    interface VoitureService
    {
        public IEnumerable<Voiture> TrouverTout();
        public Voiture TrouverUn(int id);
        public Voiture Modifier(Voiture v);
        public Voiture Save(Voiture v);
        public void Supprimer(int id);
    }
}
