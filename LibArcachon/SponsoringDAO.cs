using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class SponsoringDAO
    {
        public static string Add (Sponsoring sponsoring)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Sponsoring.Add(sponsoring);
            string Retour = System.String.Format("La sponsorisation {0} a bien été faite");
            db.SaveChanges();
            return Retour;
        }
    }
}
