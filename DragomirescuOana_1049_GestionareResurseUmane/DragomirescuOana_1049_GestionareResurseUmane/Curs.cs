using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
   public class Curs
    {
        private int idCurs;
        private string denumireCurs;
        private string denumireDepartament;
        private int nrOre;

        public Curs()
        {

        }
        public Curs(int idCurs, string denCurs, string denDep, int nrO)
        {
            this.idCurs = idCurs;
            this.denumireCurs = denCurs;
            this.denumireDepartament = denDep;
            this.nrOre = nrO;
        }
        public static Curs FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Curs curs = new Curs();
            curs.idCurs = int.Parse(values[0]);
            curs.denumireCurs = values[1];
            curs.denumireDepartament = values[2];
            curs.nrOre = int.Parse(values[3]);
            return curs;
        }
        public static string AsCsv(Curs curs)
        {
            return string.Format(
                "{0},{1},{2},{3}",
               curs.idCurs.ToString(),
               curs.denumireCurs,
               curs.denumireDepartament,
               curs.nrOre.ToString());
        }
        public int IDCurs
        {
            get { return this.idCurs; }
            set { this.idCurs = value; }
        }
        public string DenumireCurs
        {
            get { return this.denumireCurs; }
            set { this.denumireCurs = value; }
        }
        public string DenumireDepartament
        {
            get { return this.denumireDepartament; }
            set { this.denumireDepartament = value; }
        }

        public int NrOre
        {
            get { return this.nrOre; }
            set { this.nrOre = value; }
        }

        public override string ToString()
        {
            string rezultat = null;
            rezultat += "Cursul " + this.denumireCurs + " cu id-ul " + this.idCurs +" din cadrul departamentului " + this.denumireDepartament + " dureaza " + this.nrOre + " ore.";
           
            return rezultat;
        }


    }
}
