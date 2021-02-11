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
    public partial class VizualizareCursuri : Form
    {
        private Meniu meniu;
        private Font verdana10Font;
        private StreamReader reader;
        PrintDialog printDialog1 = new PrintDialog();
        public VizualizareCursuri(Meniu meniu)
        {
            this.meniu = meniu;
            InitializeComponent();
            foreach (Curs c in this.meniu.ListaCursuri)
            {
                ListViewItem livi = new ListViewItem(c.IDCurs.ToString());
                livi.SubItems.Add(c.DenumireCurs);
                livi.SubItems.Add(c.DenumireDepartament);
                livi.SubItems.Add(c.NrOre.ToString());

                this.lvCursuri.Items.Add(livi);
            }
        }
        private void reload()
        {
            this.lvCursuri.Items.Clear();
            foreach (Curs c in this.meniu.ListaCursuri)
            {
                ListViewItem livi = new ListViewItem(c.IDCurs.ToString());
                livi.SubItems.Add(c.DenumireCurs);
                livi.SubItems.Add(c.DenumireDepartament);
                livi.SubItems.Add(c.NrOre.ToString());
                this.lvCursuri.Items.Add(livi);
            }
        }
        private void bAdaugaCurs_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu.Show();
        }

        private void citireDateDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                List<Curs> values = File.ReadAllLines(folderBrowserDialog.FileName).Skip(0).Select(v => Curs.FromCsv(v)).ToList();
                this.meniu.ListaCursuri = values;
                reload();
            }
        }

        private void salvareDateInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] arrayCursuri = new string[this.meniu.ListaCursuri.Count];
                for (int i = 0; i < this.meniu.ListaCursuri.Count; i++)
                {
                    arrayCursuri[i] = Curs.AsCsv(this.meniu.ListaCursuri.ElementAt(i));
                }
                File.WriteAllText(saveFileDialog.FileName,
                 string.Join(Environment.NewLine, arrayCursuri));
            }
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
