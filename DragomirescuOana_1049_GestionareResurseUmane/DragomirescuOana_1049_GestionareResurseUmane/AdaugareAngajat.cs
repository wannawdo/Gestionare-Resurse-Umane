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
    public partial class AdaugareAngajat : Form
    {
        private Meniu meniu;
       
        public AdaugareAngajat(Meniu meniu)
        {
            this.meniu = meniu;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu.Show();
        }

        private bool checkNullOrEmpty()
        {
            if (String.IsNullOrEmpty(textBoxNume.Text))
            {
                MessageBox.Show("Numele trebuie completat");
                return true;
            }

            if (String.IsNullOrEmpty(textBoxPrenume.Text))
            {
                MessageBox.Show("Prenumele trebuie completat");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxDepartamemt.Text))
            {
                MessageBox.Show("Departametul trebuie completat");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxStudii.Text))
            {
                MessageBox.Show("Studiile trebuie completate");
                return true;
            }
            if (String.IsNullOrEmpty(textBoxCNP.Text))
            {
                MessageBox.Show("CNP-ul trebuie completat");
                return true;
            }
            return false;
        }

        private void buttonAdaugaAngajat_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkNullOrEmpty())
                {
                    return;
                }
                Persoana prs = new Persoana(textBoxCNP.Text, textBoxNume.Text, textBoxPrenume.Text, dateTimePickerDataAng.Value, int.Parse(textBoxExperienta.Text), int.Parse(textBoxSalariu.Text), textBoxDepartamemt.Text, textBoxStudii.Text);
                this.meniu.adaugaAngajat(prs);
                MessageBox.Show("Angajatul a fost adaugat");
                this.Close();
                meniu.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ceva nu a functionat corect!");
            }
            finally
            {
                textBoxCNP.Clear();
                textBoxNume.Clear();
                textBoxPrenume.Clear();
                textBoxExperienta.Clear();
                textBoxSalariu.Clear();
                textBoxDepartamemt.Clear();
                textBoxStudii.Clear();
            }
        }

        private void textBoxCNP_Validating(object sender, CancelEventArgs e)
        {
           if(textBoxCNP.Text.Length!=13)
            {
                textBoxCNP.Focus();
                epCNP.SetError(textBoxCNP, "CNP-ul trebuie sa aiba 13 caractere.");
            }
        }

        private void textBoxCNP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apasa click dreapta pentru a formata scrisul.");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBoxCNP.Font = dlg.Font;
                textBoxDepartamemt.Font = dlg.Font;
                textBoxExperienta.Font = dlg.Font;
                textBoxNume.Font = dlg.Font;
                textBoxPrenume.Font = dlg.Font;
                textBoxSalariu.Font = dlg.Font;
                textBoxStudii.Font = dlg.Font;
            }
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBoxCNP.ForeColor = dlg.Color;
                textBoxDepartamemt.ForeColor = dlg.Color;
                textBoxExperienta.ForeColor = dlg.Color;
                textBoxNume.ForeColor = dlg.Color;
                textBoxPrenume.ForeColor = dlg.Color;
                textBoxSalariu.ForeColor = dlg.Color;
                textBoxStudii.ForeColor = dlg.Color;
            }
        }

        private void textBoxCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSalariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBoxStudii_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
