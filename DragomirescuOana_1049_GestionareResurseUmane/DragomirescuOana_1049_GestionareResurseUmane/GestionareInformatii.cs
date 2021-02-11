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
    public partial class GestionareInformatii : Form
    {
        Meniu meniu;
        int nrobs; //date membre in form
        int[] y;
        string[] x;
        public GestionareInformatii(Meniu m)
        {
            InitializeComponent();
            meniu = m;
            nrobs = 2;
            x = new string[] { "Femei", "Barbati" };
            y = new int[] { 0,0 };
            this.ResizeRedraw = true;

            //imi iau angajatii dupa prima cifra a cnp-ului
            foreach (Persoana p in this.meniu.ListaAngajati)
            {
                if (p.Cnp[0] == '2' || p.Cnp[0] == '6')
                {
                    y[0]++;
                }
                else
                {
                    y[1]++;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            this.Hide();
            meniu.Show();
        }

        private void panelSexe_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.Thistle);      
            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20;
            zonaClient.Y += 20; //lasam niste spatii
            zonaClient.Height -= 40;
            zonaClient.Width -= 40;
            //desenam un chenar rosu
            Pen creionRoz = new Pen(Color.Black, 2);
            g.DrawRectangle(creionRoz, zonaClient);//cu ce desenam +dreptunghiul

            int i, vl = zonaClient.Left, vb = zonaClient.Bottom, vr = zonaClient.Right, vt = zonaClient.Top;//v=valoare

            float rap_dist_lat = 0.2f, max; //distanta intre dreptunghiuri
            //vom defini creioane si brush-uri pt a avea culoi diferite
            SolidBrush[] pensule = new SolidBrush[] { new SolidBrush(Color.Black), new SolidBrush(Color.Black) };
            Pen[] creioane = new Pen[] { new Pen(Color.Black), new Pen(Color.Black) };
            //vom folosi doua variabile locale: pensula curenta si creion curent 
            SolidBrush pnsCrt;
            Pen penCrt;
            //calculam latimea unui dreptunghi plus spatiul
            int lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs) - 40;
            int dist = (int)(lat * rap_dist_lat);
            for (max = y[0], i = 1; i < nrobs; i++)
                if (max < y[i])
                    max = y[i];
            penCrt = creioane[0]; pnsCrt = pensule[0];
            g.DrawLine(penCrt, vl, vt, vl, vb); //oy
            g.DrawLine(penCrt, vl, vb, vr, vb); //ox
            penCrt = creioane[1];
            for (i = 0; i < nrobs; i++)
            {
                //un dreptunghi se definsete prin coltul stanga sus al drept,x,y,width,high
                pnsCrt = pensule[i % 2]; 
                PointF pnt = new PointF(vl + dist + i * (lat + dist), vb - y[i] * (vb - vt) / max);

                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));


                string den = x[i].ToString();
                g.DrawString(den, Font, pnsCrt, vl + dist + lat / 2 + i * (lat + dist) - 25, vb + 2);

            }
        }
        private void panelSexe_Resize_1(object sender, EventArgs e)
        {
            panelSexe.Invalidate();
        }
    }
}

