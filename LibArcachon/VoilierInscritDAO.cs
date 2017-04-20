using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    class VoilierInscritDAO
    {

        public static void Add(VoilierInscrit VoilierInscrit)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.VoilierInscrit.Add(VoilierInscrit);
            db.SaveChanges();
        }






    }
}
