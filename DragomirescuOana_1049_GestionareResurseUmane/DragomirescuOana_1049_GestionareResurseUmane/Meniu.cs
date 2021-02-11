using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    public partial class Meniu : Form
    {
        private AdaugareAngajat adaugareAngajat;
        private AdaugareCurs adaugareCurs;
        private AdaugareJob adaugareJob;
        private VizualizareAngajati vizualizareAngajati;
        private VizualizareCursuri vizualizareCursuri;
        private lvJoburi vizualizareJoburi;

        // Lista obiecte
        private List<Persoana> listaAngajati;
        private List<Job> listaJoburi;
        private List<Curs> listaCursuri;
        public Meniu()
        {
            Persoana test = new Persoana("2990829480070", "Dragomirescu", "Oana", DateTime.Parse("1/10/2020 1:04:22"), 3, 20000, "IT", "Superioare");
            Persoana test1 = new Persoana("1770423460079", "Popescu", "Viorel", DateTime.Parse("1/10/2020 1:04:22"), 3, 50000, "IT", "Superioare");
            Persoana test2 = new Persoana("5590829480070", "Mihai", "Ion", DateTime.Parse("1/10/2020 1:04:22"), 3, 2000, "Marketing", "Superioare");
            Persoana test3 = new Persoana("6990829480070", "Vasile", "Mihaela", DateTime.Parse("1/10/2020 1:04:22"), 3, 8400, "HR", "Superioare");
            Persoana test4 = new Persoana("1990829480070", "Ion", "Andrei", DateTime.Parse("1/10/2020 1:04:22"), 3, 2000, "IT", "Superioare");
            Persoana test5 = new Persoana("2990829480070", "Ionescu", "Gerorgiana", DateTime.Parse("1/10/2020 1:04:22"), 3, 45000, "HR", "Superioare");
            Persoana test6 = new Persoana("2990829480070", "Florea", "Laura", DateTime.Parse("1/10/2020 1:04:22"), 3, 10000, "IT", "Superioare");
            Persoana test7 = new Persoana("2990829480070", "Gheorge", "Lavinia", DateTime.Parse("1/10/2020 1:04:22"), 3, 1000, "HR", "Superioare");
            Persoana test8 = new Persoana("2990829480070", "Dumitru", "Alexandra", DateTime.Parse("1/10/2020 1:04:22"), 3, 5000, "HR", "Liceale");
            Curs testC = new Curs(110, "Java", "IT", 4);
            Curs testC2 = new Curs(111, "Time Management", "HR", 2);
            Curs testC3 = new Curs(112, "C#", "IT", 12);
            Curs testC4 = new Curs(113, "Dezvoltare persoanala", "HR", 4);
            Job testJ = new Job("Web Developer", 5, 20000, 10000);
            Job testJ2 = new Job("Java Developer", 5, 200000, 100000);
            Job testJ3 = new Job("Programator Ajutor", 1, 1000, 2500);
            Job testJ4 = new Job("HR Manager", 4, 7000, 9000);
            listaAngajati = new List<Persoana>();
            listaAngajati.Add(test);
            listaAngajati.Add(test1);
            listaAngajati.Add(test2);
            listaAngajati.Add(test3);
            listaAngajati.Add(test4);
            listaAngajati.Add(test5);
            listaAngajati.Add(test6);
            listaAngajati.Add(test7);
            listaAngajati.Add(test8);
            listaJoburi = new List<Job>();
            listaJoburi.Add(testJ);
            listaJoburi.Add(testJ2);
            listaJoburi.Add(testJ3);
            listaJoburi.Add(testJ4);
            listaCursuri = new List<Curs>();
            listaCursuri.Add(testC);
            listaCursuri.Add(testC2);
            listaCursuri.Add(testC3);
            listaCursuri.Add(testC4);
            InitializeComponent();
        }
        public List<Curs> ListaCursuri
        {
            get { return this.listaCursuri; }
            set { this.listaCursuri = value; }
        }
        public List<Job> ListaJoburi
        {
            get { return this.listaJoburi; }
            set { this.listaJoburi = value; }
        }
        public List<Persoana> ListaAngajati
        {
            get { return this.listaAngajati; }
            set { this.listaAngajati = value; }
        }

        public void adaugaAngajat(object persoana)
        {
            Persoana prs = (Persoana)persoana;
            listaAngajati.Add(prs);
        }
        public void adaugaCurs(object curs)
        {
            Curs crs = (Curs)curs;
            listaCursuri.Add(crs);
        }
        public void adaugaJob(object job)
        {
            Job j = (Job)job;
            listaJoburi.Add(j);
        }

        private void buttonAdaugaAngajati_Click(object sender, EventArgs e)
        {
            adaugareAngajat = new AdaugareAngajat(this);
            adaugareAngajat.Show();
            this.Hide(); // sa ascund meniul principal
        }

        private void buttonAdaugaCursuri_Click(object sender, EventArgs e)
        {
            adaugareCurs = new AdaugareCurs(this);
            this.Hide();
            adaugareCurs.Show();
        }

        private void buttonAdaugaJoburi_Click(object sender, EventArgs e)
        {
            adaugareJob = new AdaugareJob(this);
            this.Hide();
            adaugareJob.Show();
        }

        private void buttonVizualizareAngajati_Click(object sender, EventArgs e)
        {
            vizualizareAngajati = new VizualizareAngajati(this);
            this.Hide();
            vizualizareAngajati.Show();
        }

        private void buttonVizualizareCursuri_Click(object sender, EventArgs e)
        {
            vizualizareCursuri = new VizualizareCursuri(this);
            this.Hide();
            vizualizareCursuri.Show();
        }

        private void buttonVizualaizareJoburi_Click(object sender, EventArgs e)
        {
            vizualizareJoburi = new lvJoburi(this);
            this.Hide();
            vizualizareJoburi.Show();
        }

        private void buttonGestionareInformatii_Click(object sender, EventArgs e)
        {
            GestionareInformatii gi = new GestionareInformatii(this);
            this.Hide();
            gi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonToDoList_Click(object sender, EventArgs e)
        {
            ToDoList todolist = new ToDoList();
            this.Hide();
            todolist.Show();
         
        }
    }
}
