using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    public class Job
    {
        private string denumireJob;
        private int experientaNecesara; //numarul de ani de experienta in domeniu
        private int salariuMax;
        private int salariuMin;

        public Job()
        {

        }
        public Job(string d, int expNeces, int max, int min)
        {
            this.denumireJob = d;
            this.experientaNecesara = expNeces;
            this.salariuMax = max;
            this.salariuMin = min;
        }
        public static Job FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Job job = new Job();
            job.denumireJob = values[0];        
            job.experientaNecesara = int.Parse(values[1]);
            job.salariuMax = int.Parse(values[2]);
            job.salariuMin = int.Parse(values[3]);
            return job;
        }
        public static string AsCsv(Job job)
        {
            return string.Format(
                "{0},{1},{2},{3}",
               job.denumireJob,
            job.experientaNecesara.ToString(),
            job.salariuMax.ToString(),
            job.salariuMin.ToString());
        }
        public string DenumireJob
        {
            get { return this.denumireJob; }
            set { this.denumireJob = value; }
        }
        public int ExperientaNecesara
        {
            get { return this.experientaNecesara; }
            set { this.experientaNecesara = value; }
        }
        public int SalariuMax
        {
            get { return this.salariuMax; }
            set { this.salariuMax = value; }
        }

        public int SalariuMin
        {
            get { return this.salariuMin; }
            set { this.salariuMin = value; }
        }

        public override string ToString()
        {
            string result = null;
            return result += "Jobul cu denumirea " + this.denumireJob + " poate avea salariul cuprins intre " + this.salariuMin + " si " + this.salariuMax + ". Experienta necesara pentru acest job este de " + this.experientaNecesara + " ani.";
        }

    }
}
