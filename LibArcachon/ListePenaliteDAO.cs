using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class ListePenaliteDAO
    {

        public static List<ListePenalite> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<ListePenalite> listepenalite = db.ListePenalite.ToList();
            return listepenalite;
        }


        public static ListePenalite Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            ListePenalite listepenalite = db.ListePenalite.Find(id);
            return listepenalite;
        }
        public static string Edit(ListePenalite listependalite)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.ListePenalite.Attach(listependalite);
            db.Entry(listependalite).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("La pénalité {0} à bien été modifié", listependalite.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static string Delete(ListePenalite listepenalite)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.ListePenalite.Remove(listepenalite);
            string Retour = System.String.Format("La penalite {0} à bien été supprimé", listepenalite.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static void Add(ListePenalite lapena)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.ListePenalite.Add(lapena);
            db.SaveChanges();
        }


    }
}
