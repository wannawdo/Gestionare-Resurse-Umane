using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    [Serializable]
    public class Persoana: IComparable
    {
        private string cnp;
        private string nume;
        private string prenume;
        private DateTime dataAngajare;
        private int experienta;
        private int salariu;
        private string departament;
        private string studii;
        
        public Persoana()
        {

        }
        public Persoana(string cnp, string nume, string prenume, DateTime dataAng, int exp, int sal, string dep, string studii)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.prenume = prenume;
            this.dataAngajare = dataAng;
            this.experienta = exp;
            this.salariu = sal;
            this.departament = dep;       
            this.studii = studii;
        }

        public static Persoana FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Persoana persoana = new Persoana();
            persoana.Cnp = values[0];
            persoana.nume = values[1];
            persoana.prenume = values[2];
            persoana.dataAngajare = DateTime.Parse(values[3]);
            persoana.experienta = int.Parse(values[4]);
            persoana.salariu = int.Parse(values[5]);
            persoana.departament = values[6];
            persoana.studii = values[7];
            return persoana;
        }

        public static string AsCsv(Persoana persoana)
        {
            return string.Format(
                "{0},{1},{2},{3},{4},{5},{6},{7}",
                persoana.Cnp,
                persoana.Nume,
                persoana.prenume,
                persoana.dataAngajare.ToString(),
                persoana.experienta.ToString(),
                persoana.salariu.ToString(),
                persoana.departament,
                persoana.studii);
        }

        public string Cnp
        {
            get { return this.cnp; }
            set { this.cnp = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Prenume
        {
            get { return this.prenume; }
            set { this.prenume = value; }
        }
            
        public DateTime DataAngajare
        {
            get { return this.dataAngajare; }
            set { this.dataAngajare = value; }
        }
        public int Experienta
        {
            get { return this.experienta; }
            set { this.experienta = value; }
        }

        public int Salariu
        {
            get { return this.salariu; }
            set { this.salariu = value; }
        }


        public string Departament
        {
            get { return this.departament; }
            set { this.departament = value; }
        }

        public string Studii
        {
            get { return this.studii; }
            set { this.studii = value; }
        }


        public int CompareTo(object obj)
        {
            Persoana p = (Persoana)obj;
            if (this.salariu < p.salariu)
            {
                return -1;
            }
            else if (this.salariu > p.salariu)
            {
                return 1;
            }
            else
            {
                return string.Compare(this.nume, p.nume);
            }
        }


        public override string ToString()
        {
            string result = null;
            result += "Persoana " + this.nume + " " + this.prenume + "avand CNP-ul " + this.cnp + " si apartinand departamentului: " + this.departament + ", are o experienta de " + this.experienta + " ani si un salariu de " + this.salariu + " lei.";
            return result;
        }

    }
}
