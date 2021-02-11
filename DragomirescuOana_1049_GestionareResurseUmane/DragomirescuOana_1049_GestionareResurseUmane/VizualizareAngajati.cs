using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    public partial class VizualizareAngajati : Form
    {
        Meniu meniu;
        PrintDialog printDialog1 = new PrintDialog();
        private Font verdana10Font;
        private StreamReader reader;
        public VizualizareAngajati(Meniu meniu)
        {
            this.meniu = meniu;
            InitializeComponent();
            ListView liv = new ListView();
            foreach (Persoana p in this.meniu.ListaAngajati)
            {
                ListViewItem liviCnp = new ListViewItem(p.Cnp);
                liviCnp.SubItems.Add(p.Nume);
                liviCnp.SubItems.Add(p.Prenume);
                liviCnp.SubItems.Add(p.DataAngajare.ToString());
                liviCnp.SubItems.Add(p.Experienta.ToString());
                liviCnp.SubItems.Add(p.Salariu.ToString());
                liviCnp.SubItems.Add(p.Departament);
                liviCnp.SubItems.Add(p.Studii);
                this.lvAngajati.Items.Add(liviCnp);
            }
        }

        private void reload()
        {
            this.lvAngajati.Items.Clear();
            foreach (Persoana p in this.meniu.ListaAngajati)
            {
                ListViewItem liviCnp = new ListViewItem(p.Cnp);
                liviCnp.SubItems.Add(p.Nume);
                liviCnp.SubItems.Add(p.Prenume);
                liviCnp.SubItems.Add(p.DataAngajare.ToString());
                liviCnp.SubItems.Add(p.Experienta.ToString());
                liviCnp.SubItems.Add(p.Salariu.ToString());
                liviCnp.SubItems.Add(p.Departament);
                liviCnp.SubItems.Add(p.Studii);
                this.lvAngajati.Items.Add(liviCnp);

            }
        }
        private void bAdaugaAngajat_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu.Show();
        }
        private void citireDateDinFisierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                List<Persoana> values = File.ReadAllLines(folderBrowserDialog.FileName).Skip(0).Select(v => Persoana.FromCsv(v)).ToList();
                this.meniu.ListaAngajati = values;
                reload();
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                lvAngajati.Font = dlg.Font;
            }
        }
        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                lvAngajati.ForeColor = dlg.Color;
            }
        }
        private void buttonPersonalizeaza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apasa click dreapta pe chenarul cu angajatii pentru a schimba preferintele de font si culoare.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openfd = new OpenFileDialog();
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    string path = openfd.InitialDirectory + openfd.FileName;
                    reader = new StreamReader(path);
                    // Verdana font, size 10  
                    verdana10Font = new Font("Verdana", 10);        
                    PrintDocument pd = new PrintDocument();//print eventhandler       
                    pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);                  
                    pd.Print();
                    if (reader != null)
                        reader.Close();
                }
            }
        }
        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {           
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //imi citesc marginile paginii
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //citesc liniile folosind StreamReader 
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //pozitia de inceput 
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //desenez textul  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //ma mut la urmatoarea linie
                count++;
            }
            //daca avem mai multe pagini de printat 
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void salvareDateInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] arrayPersoane = new string[this.meniu.ListaAngajati.Count];
                for (int i = 0; i < this.meniu.ListaAngajati.Count; i++)
                {
                    arrayPersoane[i] = Persoana.AsCsv(this.meniu.ListaAngajati.ElementAt(i));
                }
                File.WriteAllText(saveFileDialog.FileName,
                 string.Join(Environment.NewLine, arrayPersoane));
            }
        }
    }
}

