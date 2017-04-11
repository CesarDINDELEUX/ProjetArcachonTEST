using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class TypeDeClasseDAO
    {


        public static List<TypeDeClasse> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<TypeDeClasse> listetypedeclasse = db.TypeDeClasse.ToList();
            return listetypedeclasse;
        }


        public static TypeDeClasse Select(int id)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            TypeDeClasse typedeclasse = db.TypeDeClasse.Find(id);
            return typedeclasse;
        }
        public static string Edit(TypeDeClasse typedeclasse)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.TypeDeClasse.Attach(typedeclasse);
            db.Entry(typedeclasse).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("Le type de classe {0} à bien été modifié", typedeclasse.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static string Delete(TypeDeClasse typedeclasse)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.TypeDeClasse.Remove(typedeclasse);
            string Retour = System.String.Format("Le type de classe {0} à bien été supprimé", typedeclasse.Nom);
            db.SaveChanges();
            return Retour;
        }

        public void TypeClasse (string nom, string description)
        {
            TypeDeClasse NouvelleClasse = new TypeDeClasse { Nom = nom, Descrption = description };
            TypeDeClasseDAO.Add(NouvelleClasse);
        }

        public static string Add(TypeDeClasse typedeclasse)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.TypeDeClasse.Add(typedeclasse);
            string Retour = System.String.Format("Le type de classe {0} à bien été ajouté", typedeclasse.Nom);
            db.SaveChanges();
            return Retour;
        }


        public static string getnomclasse(int idclasse)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            string nomclasse = db.TypeDeClasse.Where(x => x.Id_Classe == idclasse).ToString();
            return nomclasse;
        }




    }
}
