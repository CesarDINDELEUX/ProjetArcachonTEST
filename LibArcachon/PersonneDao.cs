using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class PersonneDao
    {
        /// <summary>
        /// Liste Toute  personnes et renvois une liste de personnes
        /// </summary>
        /// <returns>Liste personne comme une List Personne</returns>
        public static List<Personne> List()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Personne> Listpersonne = db.Personne.ToList();
            return Listpersonne;
        }
        /// <summary>
        /// Trouve une seule Personne en fonction de son id unique
        /// </summary>
        /// <param name="id">id de la Personne</param>
        /// <returns>Retourne une Personne unique dans objet Personne</returns>
        public static Personne Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Personne personne = db.Personne.Find(id);
            return personne;
        }
        /// <summary>
        /// Prend en params une Personne à editer la change et renvois un message
        /// </summary>
        /// <param name="Personne">Personne à éditer</param>
        /// <returns>Message de confirmation d'édition</returns>
        public static string Edit(Personne personne)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Personne.Attach(personne);
            db.Entry(personne).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Changement de Personne effectué";

        }
        /// <summary>
        /// Prend en params une Personne à supprimer la supprime et renvois un message
        /// </summary>
        /// <param name="personne">Parsonne à supprimer</param>
        /// <returns>Renvois un message de confirmation</returns>
        public static string Delete(Personne personne)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Personne.Attach(personne);
            db.Personne.Remove(personne);
            db.SaveChanges();
            return "Suppression de la personne effectué";

        }
        /// <summary>
        /// Permet d'ajouter une personne
        /// </summary>
        /// <param name="personne">Personne a ajouter</param>
        /// <returns>Retourne message de confirmation</returns>
        public static string Add(Personne personne)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Personne.Add(personne);
            db.SaveChanges();
            return "Ajout de la personne effectué";
        }

    }
}
