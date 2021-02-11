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
    public partial class AdaugareCurs : Form
    {
        private Meniu meniu;

        public AdaugareCurs(Meniu meniu)
        {
            this.meniu = meniu;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu.Show();
        }
        private bool checkNullorEmpty()
        {
            if (String.IsNullOrEmpty(textBoxIDCurs.Text))
            {
                MessageBox.Show("ID-ul cursului trebuie completat.");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxDenumireCurs.Text))
            {
                MessageBox.Show("Denumirea cursului trebuie completata.");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxdenumireDepartament.Text))
            {
                MessageBox.Show("Denumirea departamentului trebuie completata.");
                return true;
            }
            if(String.IsNullOrEmpty(textBoxNrOre.Text))
            {
                MessageBox.Show("Numarul de ore trebuie completat");
                return true;
            }
            return false;
        }
        private void buttonAdaugaCurs_Click(object sender, EventArgs e)
        {
            if(checkNullorEmpty())
            {
                return;
            }
            Curs crs = new Curs(int.Parse(textBoxIDCurs.Text), textBoxDenumireCurs.Text, textBoxdenumireDepartament.Text, int.Parse(textBoxNrOre.Text));
            if (int.Parse(textBoxNrOre.Text) < 0)
            {
                MessageBox.Show("Numarul de ore este invalid");
                return;
            }
            if (int.Parse(textBoxIDCurs.Text) < 0)
            {
                MessageBox.Show("ID-ul cursului este invalid");
                return;
            }
            this.meniu.adaugaCurs(crs);
            MessageBox.Show("Cursul a fost adaugat");
            this.Close();
            meniu.Show();
        }

        private void textBoxNrOre_Validating(object sender, CancelEventArgs e)
        {
            if(int.Parse(textBoxNrOre.Text) <2)
            {
                textBoxNrOre.Focus();
                epDurataCurs.SetError(textBoxNrOre, "Cursul nu poate dura mai putin de o ora.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxIDCurs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
