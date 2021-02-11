using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragomirescuOana_1049_GestionareResurseUmane
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogare_Click(object sender, EventArgs e)
        {
            string conString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Logare.accdb";
            string comanda = "Select Count(*) from Logare where NumeUtilizator=? and [Parola]=?";
            using (OleDbConnection con = new OleDbConnection(conString))
            using (OleDbCommand cmd = new OleDbCommand(comanda, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@p1", tbUser.Text);
                cmd.Parameters.AddWithValue("@p2", tbParola.Text);
                if (tbUser.Text == "" || tbParola.Text == "")
                {
                    MessageBox.Show("Userul si parola trebuie completate!");
                    return;
                }
                int rez = (int)cmd.ExecuteScalar();
                if (rez > 0)
                {
                    this.Hide();
                    Meniu meniu = new Meniu();
                    meniu.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Username sau parola gresita!");

                    tbParola.Clear();
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
