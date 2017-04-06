using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class VoilierDAO
    {

        public static List<Voilier> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Voilier> listevoilier = db.Voilier.ToList();
            return listevoilier;
        }


        public static Voilier Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            Voilier voilier = db.Voilier.Find(id);
            return voilier;
        }
        public static string Edit(Voilier voilier)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Voilier.Attach(voilier);
            db.Entry(voilier).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("Le voilier {0} à bien été modifié", voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static string Delete(Voilier voilier)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Voilier.Remove(voilier);
            string Retour = System.String.Format("Le voilier {0} à bien été supprimé", voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static string Add(Voilier voilier)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Voilier.Add(voilier);
            string Retour = System.String.Format("Le voilier {0} à bien été ajouté", voilier.Nom);
            db.SaveChanges();
            return Retour;
        }





    }
}
