using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class EpreuveDAO
    {
        /// <summary>
        /// Permet d'ajouter une epreuve
        /// </summary>
        /// <param name="epreuve">Course a ajouté</param>
        /// <returns>Retourne message de confirmation</returns>
        public static void Add(Epreuve epreuve)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Epreuve.Add(epreuve);
            db.SaveChanges();
        }

        /// <summary>
        /// Supprimer une Epreuve
        /// </summary>
        /// <param name="epreuve">L'epreuve choisie</param>
        /// <returns>Phrase de confirmation (string)</returns>
        public static string Delete(Epreuve epreuve)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Epreuve.Remove(epreuve);
            string Retour = System.String.Format("L'epreuve {0} à bien été supprimé de la course {1}", epreuve.Id_Epreuve, epreuve.Course.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Supprimer une epreuve par son ID
        /// </summary>
        /// <param name="id">Id de l'epreuve</param>
        /// <returns>Retourne une confirmation(string)</returns>
        public static string Delete(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Epreuve epreuve = db.Epreuve.Find(id);
            db.Epreuve.Remove(epreuve);
            string Retour = System.String.Format("L'Epreuve {0} à bien été supprimé de la course {1}", epreuve.Id_Epreuve, epreuve.Course.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// modifier une epreuve
        /// </summary>
        /// <param name="epreuve">L'epreuve choisie</param>
        /// <returns>Retourne une confirmation (string)</returns>
        public static string Edit(Epreuve epreuve)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Epreuve.Attach(epreuve);
            db.Entry(epreuve).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("L'Epreuve {0} à bien été modifié", epreuve.Id_Epreuve);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// modifier une epreuve par son id
        /// </summary>
        /// <param name="epreuveid">id de l'epreuve</param>
        /// <returns>Retourne une confirmation</returns>
        public static string Edit(int epreuveid)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Epreuve epreuve = db.Epreuve.Find(epreuveid);
            db.Epreuve.Attach(epreuve);
            db.Entry(epreuve).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("L'Epreuve {0} à bien été modifié", epreuve.Id_Epreuve);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Selectioner une epreuve
        /// </summary>
        /// <param name="id">ID de l'epreuve</param>
        /// <returns>retourne une epreuve</returns>
        public static Epreuve Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Epreuve epreuve = db.Epreuve.Find(id);
            return epreuve;
        }

        /// <summary>
        /// Lister les epreuves d'une course
        /// </summary>
        /// <param name="courseid">id de la course</param>
        /// <returns>retourne la liste des épreuves d'une course</returns>
        public static List<Epreuve> getEpreuvesByCourse(int courseid)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Epreuve> listEpreuveParCourse = db.Epreuve.Where(f => f.idcourse == courseid).ToList();
            return listEpreuveParCourse;
        }



    }
}
