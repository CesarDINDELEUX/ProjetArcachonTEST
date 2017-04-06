using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class CourseDAO
    {
        /// <summary>
        /// Liste Toutessees les courszdqzde et renvois une liste de courses
        /// </summary>
        /// <returns>ListeCourse comme une List Course</returns>
        public static List<Course> List() {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Course> ListeCourse = db.Course.ToList();
            return ListeCourse;
        }
        /// <summary>
        /// Trouve une seule course en fonction de son id unique
        /// </summary>
        /// <param name="id">id de la course</param>
        /// <returns>Retourne une course unique dans objet course</returns>
        public static Course Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Course course = db.Course.Find(id);
            return course;
        }
        /// <summary>
        /// Prend en params une course à editer la change et renvois un message
        /// </summary>
        /// <param name="course">Course à éditer</param>
        /// <returns>Message de confirmation d'édition</returns>
        public static string Edit(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Course.Attach(course);
            db.Entry(course).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Changement de course effectué";
            
        }
        /// <summary>
        /// Prend en params une course à editer la change et renvois un message
        /// </summary>
        /// <param name="course">Course à supprimer</param>
        /// <returns>Renvois un message de confirmation</returns>
        public static string Delete(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Course.Attach(course);
            db.Course.Remove(course);
            db.SaveChanges();
            return "Suppression de la course effectué";

        }
        /// <summary>
        /// Permet d'ajouter une course
        /// </summary>
        /// <param name="course">Course a ajouté</param>
        /// <returns>Retourne message de confirmation</returns>
        public static string Add(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Course.Add(course);
            db.SaveChanges();
            return "Ajout de la course effectué";
        }
        /// <summary>
        /// Recupère Les epreuves en fonction d'une course
        /// </summary>
        /// <param name="course">Course avec epreuve</param>
        /// <returns>Retourne une liste d'epreuves</returns>
      public static List<Epreuve> GetEpreuves(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Epreuve> ListEpreuve = db.Epreuve
                                        .Where(f => f.idcourse == course.Id_Course)
                                        .ToList();
            return ListEpreuve;
                                        
        }
        /// <summary>
        /// Recupère les repreuves en fonction de l'id de la course
        /// </summary>
        /// <param name="idCourse">Id de la course</param>
        /// <returns>Retourne une liste d'epreuve</returns>
        public static List<Epreuve> GetEpreuves(int idCourse)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Course course = db.Course.Find(idCourse);
            List<Epreuve> ListEpreuve = db.Epreuve
                                        .Where(f => f.idcourse == course.Id_Course)
                                        .ToList();
            return ListEpreuve;

        }
        /// <summary>
        /// Recupère les voiliers inscrits sur une course
        /// </summary>
        /// <param name="course">Enitité course</param>
        /// <returns>Liste voilié inscrit</returns>
        public static List<VoilierInscrit> GetVoiliersInscrit(Course course)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List <VoilierInscrit> Voiliersinscrit = db.VoilierInscrit.Where(f => f.idCourse == course.Id_Course).ToList();
            return Voiliersinscrit;
        }
        /// <summary>
        /// Recupère les voiliers inscrits sur une course via l'id de la course
        /// </summary>
        /// <param name="courseid">id de la course</param>
        /// <returns>Liste voiliés inscrits</returns>
        public static List<VoilierInscrit> GetVoiliersInscrit(int courseid)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Course course = db.Course.Find(courseid);
            List<VoilierInscrit> Voiliersinscrit = db.VoilierInscrit.Where(f => f.idCourse == course.Id_Course).ToList();
            return Voiliersinscrit;
        }

    }
}
