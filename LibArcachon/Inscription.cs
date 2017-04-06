using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class Inscription
    {

        /// <summary>
        /// Lister les inscrit d'une course par l'id de la course
        /// </summary>
        /// <param name="courseid">id de la course</param>
        /// <returns>retourne la liste des voiliers inscrit</returns>
       public static List<VoilierInscrit> getInscritByCourse(int courseid)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<VoilierInscrit> listInscrit = db.VoilierInscrit.Where(f => f.idCourse == courseid).ToList();
            return listInscrit;

                
        }
        /// <summary>
        /// Lister les inscrit d'une course par l'id de la course
        /// </summary>
        /// <param name="course">la course</param>
        /// <returns>retourne la liste des voiliers inscrit</returns>
        public static List<VoilierInscrit> getInscritByCourse(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<VoilierInscrit> listInscrit = db.VoilierInscrit.Where(f => f.idCourse == course.Id_Course).ToList();
            return listInscrit;


        }

        /// <summary>
        /// Ajouter voilier course
        /// </summary>
        /// <param name="Inscription"></param>
        /// <returns>Retourne une phrase de confirmation</returns>
        public static string InscriptionCourse(VoilierInscrit Inscription)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.VoilierInscrit.Add(Inscription);
            string Retour = System.String.Format("Le voilier {0} à bien été ajouté", Inscription.Voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Supprimer un voilier d'une course
        /// </summary>
        /// <param name="voilier">le voilier</param>
        /// <returns>Phrase de confirmation</returns>
        public static string Delete(VoilierInscrit voilier)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.VoilierInscrit.Remove(voilier);
            string Retour = System.String.Format("Le voilier {0} à bien été supprimé de la course {1}", voilier.Voilier.Nom,voilier.Course.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Supprimer un voilier d'une course
        /// </summary>
        /// <param name="id">id du voilier</param>
        /// <returns>Phrase de confirmation</returns>
        public static string Delete(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            VoilierInscrit voilier = db.VoilierInscrit.Find(id);
            db.VoilierInscrit.Remove(voilier);
            string Retour = System.String.Format("Le voilier {0} à bien été supprimé de la course {1}", voilier.Voilier.Nom, voilier.Course.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Modifier le voilier
        /// </summary>
        /// <param name="voilier">le voilier</param>
        /// <returns>Phrase de confirmation</returns>
        public static string Edit(VoilierInscrit voilier)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.VoilierInscrit.Attach(voilier);
            db.Entry(voilier).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("Le voilier {0} à bien été modifié", voilier.Voilier.Nom);
            db.SaveChanges();
            return Retour;
        }
        public static string Edit(int voilierid)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            VoilierInscrit voilier = db.VoilierInscrit.Find(voilierid);
            db.VoilierInscrit.Attach(voilier);
            db.Entry(voilier).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("Le voilier {0} à bien été modifié", voilier.Voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        /// <summary>
        /// Recupere le voilier inscrit
        /// </summary>
        /// <param name="id">id du voilier</param>
        /// <returns>Un voilier</returns>
        public static VoilierInscrit Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            VoilierInscrit voilier = db.VoilierInscrit.Find(id);
            return voilier;
        }
    }
}
