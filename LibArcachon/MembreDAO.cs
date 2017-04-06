using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class MembreDAO
    { /// <summary>
    /// s
    /// </summary>
    /// <returns></returns>
        public static List<Membre> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Membre> ListeMembre = db.Membre.ToList();
            return ListeMembre;
        }

        public static Membre Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Membre membre = db.Membre.Find(id);
                return membre;
        }
        public static string Edit(Membre membre)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Membre.Attach(membre);
            db.Entry(membre).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            string Retour = System.String.Format("Le membre {0} {1} à bien été modifié", membre.Nom, membre.Prenom);         
            return Retour;
        }

        public static string Delete(Membre membre)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Membre.Remove(membre);
            db.SaveChanges();
            string Retour = System.String.Format("Le membre {0} {1} à bien été supprimé", membre.Nom, membre.Prenom);
            return Retour;
        }

        public static string Add(Membre membre)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Membre.Add(membre);
            db.SaveChanges();
            string Retour = System.String.Format("Le membre {0} {1} à bien été ajouté", membre.Nom, membre.Prenom);
            return Retour;
        }

        public void NewMembre(string nom, string prenom, string login, string motdepasse, string email, int tel, string poste)
        {
            Membre NouveauMembre = new Membre { Nom = nom, Prenom = prenom, login = login, Mdp = motdepasse, Email = email, Tel = tel, Poste = poste };
            MembreDAO.Add(NouveauMembre);
        }


    }
}
