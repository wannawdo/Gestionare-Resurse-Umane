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
    public partial class AdaugareJob : Form
    {
        private Meniu meniu;
        public AdaugareJob(Meniu meniu)
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
            if (String.IsNullOrEmpty(textBoxDenumire.Text))
            {
                MessageBox.Show("Denumirea job-ului trebuie completata.");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxExperienta.Text))
            {
                MessageBox.Show("Experienta trebuie completata.");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxSalariuMaxim.Text))
            {
                MessageBox.Show("Salariul maxim trebuie completat.");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxSalariuMinim.Text))
            {
                MessageBox.Show("Salariul minim trebuie completat");
                return true;
            }
           
            return false;
        }
        private void buttonAdaugaJob_Click(object sender, EventArgs e)
        {
            if(checkNullorEmpty())
            {
                return;
            }
            if(int.Parse(textBoxExperienta.Text)<0)
            {
                MessageBox.Show("Experienta nu este valida.");
                return;
            }
            if (int.Parse(textBoxSalariuMinim.Text) > int.Parse(textBoxSalariuMaxim.Text))
            {
                MessageBox.Show("Salariul minim nu poate sa fie mai mare decat salariul maxim");
                return;

            }
            Job j = new Job(textBoxDenumire.Text, int.Parse(textBoxExperienta.Text), int.Parse(textBoxSalariuMaxim.Text), int.Parse(textBoxSalariuMinim.Text));
            this.meniu.adaugaJob(j);
            MessageBox.Show("Job-ul a fost adaugat");
            this.Close();
            meniu.Show();
        }

        private void textBoxDenumire_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxDenumire.Text.Length<2)
            {
                textBoxDenumire.Focus();
                epDenumireJob.SetError(textBoxDenumire, "Denumirea introdusa nu este corecta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSalariuMaxim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxSalariuMinim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
