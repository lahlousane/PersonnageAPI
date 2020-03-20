using PersonnageAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Services.Impl
{
    using Repositories;
    using Exceptions;
    public class PersonnageImplService : PersonnageService
    {
        private PersonnageRepository repository;

        public PersonnageImplService(PersonnageRepository repository)
        {
            this.repository = repository;
        }
        public Personnage Modifier(Personnage p)
        {
            return this.repository.Update(p);
        }

        public Personnage Sauvegarde(Personnage p)
        {
            return this.repository.Save(p);
        }

        public void Supprimer(int id)
        {

            this.repository.Delete(id);
            //throw new RessourceException(404, "Le pere n'existe pas, Bouuuuuu");
        }

        public IEnumerable<Personnage> TrouverTous()
        {
            return this.repository.FindAll();
        }

        public Personnage TrouverUn(int id)
        {
            return this.repository.FindById(id);
        }
    }
}
