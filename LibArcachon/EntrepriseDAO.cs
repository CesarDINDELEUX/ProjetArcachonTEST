using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class EntrepriseDAO
    {

        /// <summary>
        /// Lister les entreprises
        /// </summary>
        /// <returns>Liste d'entreprises</returns>
        public static List<Entreprise> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Entreprise> ListeEntreprise = db.Entreprise.ToList();
            return ListeEntreprise;
        }


        /// <summary>
        /// Chercher une entreprise
        /// </summary>
        /// <param name="id">Id de l'entreprise</param>
        /// <returns>Retourne une entreprise</returns>
        public static Entreprise Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Entreprise entreprise = db.Entreprise.Find(id);
            return entreprise;
        }

        /// <summary>
        /// Editer une entreprise
        /// </summary>
        /// <param name="entreprise">L'entreprise choisie.</param>
        /// <returns>Retourne une confirmation (string) </returns>
        public static void Edit(Entreprise entreprise)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Entreprise.Attach(entreprise);
            db.Entry(entreprise).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Supprimer une entreprise
        /// </summary>
        /// <param name="entreprise">Une entreprise</param>
        /// <returns>Retourne une phrase de confirmation (string)</returns>
        public static void Delete(int identreprise)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Entreprise entreprise = db.Entreprise.Find(identreprise);
            db.Entreprise.Remove(entreprise);
            db.SaveChanges();     
        }

        /// <summary>
        /// Constructeur entreprise
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="telephone"></param>
        /// <param name="mail"></param>
        /// <param name="contact"></param>
       public void Entreprise(string nom, string adresse, int telephone, string mail, string contact)
        {
            Entreprise NouvelleEntreprise = new Entreprise { Nom = nom, Adresse = adresse, Num_Tel = telephone, mail = mail, Contact = contact };
            EntrepriseDAO.Add(NouvelleEntreprise);
        }


        /// <summary>
        /// Ajouter  une nouvelle entreprise
        /// </summary>
        /// <param name="entreprise">L'entreprise</param>
        /// <returns>Retour une phrase de confirmation (string)</returns>
        public static string Add(Entreprise entreprise)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Entreprise.Add(entreprise);
            string Retour = System.String.Format("L'entreprise {0} à bien été ajouté", entreprise.Nom);
            db.SaveChanges();
            return Retour;
        }





    }
}
