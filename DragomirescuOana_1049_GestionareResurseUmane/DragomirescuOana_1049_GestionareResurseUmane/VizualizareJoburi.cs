using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    public partial class lvJoburi : Form
    {
        private Meniu meniu;
        bool vb = false;
        PrintDialog printDialog1= new PrintDialog();
        private Font verdana10Font;
        private StreamReader reader;
        public lvJoburi(Meniu meniu)
        {
            this.meniu = meniu;
            InitializeComponent();
            foreach (Job j in this.meniu.ListaJoburi)
            {
                ListViewItem liviJ = new ListViewItem(j.DenumireJob);
                liviJ.SubItems.Add(j.ExperientaNecesara.ToString());
                liviJ.SubItems.Add(j.SalariuMax.ToString());
                liviJ.SubItems.Add(j.SalariuMin.ToString());

                this.lviJoburi.Items.Add(liviJ);
            }
        }

        private void reload()
        {
            this.lviJoburi.Items.Clear();
            foreach (Job j in this.meniu.ListaJoburi)
            {
                ListViewItem liviJ = new ListViewItem(j.DenumireJob);
                liviJ.SubItems.Add(j.ExperientaNecesara.ToString());
                liviJ.SubItems.Add(j.SalariuMax.ToString());
                liviJ.SubItems.Add(j.SalariuMin.ToString());

                this.lviJoburi.Items.Add(liviJ);
            }
        }

        private void bAdaugaJob_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu.Show();
        }

        private void salvareDateInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] arrayJoburi = new string[this.meniu.ListaJoburi.Count];
                for (int i = 0; i < this.meniu.ListaJoburi.Count; i++)
                {
                    arrayJoburi[i] = Job.AsCsv(this.meniu.ListaJoburi.ElementAt(i));
                }
                File.WriteAllText(saveFileDialog.FileName,
                 string.Join(Environment.NewLine, arrayJoburi));
            }
        }

        private void citireDateDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                List<Job> values = File.ReadAllLines(folderBrowserDialog.FileName).Skip(0).Select(v => Job.FromCsv(v)).ToList();
                this.meniu.ListaJoburi = values;
                this.reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pringtPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    OpenFileDialog openfd = new OpenFileDialog();
                    if (openfd.ShowDialog() == DialogResult.OK)
                    {
                       string path = openfd.InitialDirectory + openfd.FileName;
                        reader = new StreamReader(path);
                        verdana10Font = new Font("Verdana", 10); 
                        PrintDocument pd = new PrintDocument();
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
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }
    }
}

