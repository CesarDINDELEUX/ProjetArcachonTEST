using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class ClassementEpreuve
    {
        public string IDvoilierinscrit { get; set; }
        public TimeSpan? dureePenalite { get; set; }
        public TimeSpan? temps { get; set; }
        public TimeSpan? TempsTotal { get; set; }

        public static List<ClassementEpreuve> classementEpreuve(int idepreuve)
            {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<ClassementEpreuve> lol = new List<ClassementEpreuve>();
            var resultat = from vi in db.VoilierInscrit
                           from co in db.Course.Where(x => vi.idCourse == x.Id_Course)
                           from ep in db.Epreuve.Where(x => co.Id_Course == x.idcourse)
                           from pe in db.Penalite.Where(x => vi.Id_VoilierInscrit == x.VoilierInscrit)
                           .DefaultIfEmpty()
                           from tps in db.Tps.Where(x => ep.Id_Epreuve == x.IDepreuve)
                           where tps.IDvoilierInscrit == vi.Id_VoilierInscrit && ep.Id_Epreuve == idepreuve
                           orderby tps.Temps
                            
                           select new
                           {
                               temps = tps.Temps,
                               SerialNumber = vi.NumeroSerie,
                               duree = (TimeSpan?)pe.Duree,
                               
                           };

            
            foreach (var item in resultat)
            {
                LibArcachon.ClassementEpreuve kek = new LibArcachon.ClassementEpreuve();
                
                kek.dureePenalite = PenaliteDAO.PenalParVoilier(item.SerialNumber, idepreuve);
                kek.temps = item.temps;
                if (kek.dureePenalite == null)
                {
                    kek.TempsTotal = item.temps;
                    kek.dureePenalite = TimeSpan.Parse("00:00:00");
                }
                else
                {
                    TimeSpan? tempstotalpenalite = PenaliteDAO.PenalParVoilier(item.SerialNumber, idepreuve);
                    kek.TempsTotal = item.temps + tempstotalpenalite;
                }
                
                kek.IDvoilierinscrit = item.SerialNumber;
                lol.Add(kek);
            }
            List<ClassementEpreuve> ListeClassee = lol.OrderBy(o => o.TempsTotal).Distinct().ToList();
            
            return ListeClassee.DistinctBy(x => x.IDvoilierinscrit).ToList();
            }



    }
}
