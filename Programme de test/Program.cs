using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibArcachon;

namespace Programme_de_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ProjetArcachonEntities db = new ProjetArcachonEntities();
             var resultat = from vi in db.VoilierInscrit
                            from co in db.Course.Where(x => vi.idCourse == x.Id_Course)
                            from ep in db.Epreuve.Where(x => co.Id_Course == x.idcourse)
                            from pe in db.Penalite.Where(x => vi.Id_VoilierInscrit == x.VoilierInscrit)
                            .DefaultIfEmpty()
                            from tps in db.Tps.Where(x => ep.Id_Epreuve == x.IDepreuve)
                            where tps.IDvoilierInscrit == vi.Id_VoilierInscrit

                            select new
                            {
                                temps = tps.Temps,
                                SerialNumber = vi.NumeroSerie,
                                duree = (TimeSpan?)pe.Duree
                            };
        foreach (var item in resultat)
             {
                 Console.WriteLine("Boat : {0}, TimeEpreuve : {1}, PenaltyTime : {2}, TotalTime : {3}", item.SerialNumber, item.temps, item.duree, item.temps + item.duree);
             }
             */



            TimeSpan? kek = LibArcachon.PenaliteDAO.PenalParVoilier("JYK90", 3);

            Console.ReadKey();
        }
    }
}
