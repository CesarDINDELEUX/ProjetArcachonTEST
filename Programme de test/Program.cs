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

            LibArcachon.Personne franck = new Personne { Prenom = "franck", Nom = "Lampard", Sexe = "h", Date_naissance = DateTime.Parse("30/11/1993"), Numero_Club = "221", Numero_Licence = "99788", idNumeroInscription="12" };
            LibArcachon.PersonneDao.Add(franck);
            
            
               

        }
    }
}
