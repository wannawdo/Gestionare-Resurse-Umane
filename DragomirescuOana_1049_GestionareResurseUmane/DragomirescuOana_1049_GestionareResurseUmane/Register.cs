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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            string conString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Logare.accdb";
            OleDbConnection con = new OleDbConnection(conString);

            con.Open();
           try
            {
                if (tbParola.Text != tbRepetaParola.Text)
                {
                    MessageBox.Show("Parola introdusa nu corespunde. Mai incercati o data!");
                    tbParola.Clear();
                    tbRepetaParola.Clear();
                    return;
                }
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = con;
                comanda.CommandText = "INSERT INTO Logare VALUES(?,?)";
                comanda.Parameters.Add("NumeUtilizator", OleDbType.Char, 20).Value = tbUser.Text;
                comanda.Parameters.Add("Parola", OleDbType.Char, 15).Value = tbParola.Text;
                comanda.ExecuteNonQuery();
                MessageBox.Show("V-ati inregistrat cu succes!");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) { MessageBox.Show("A aparut o eroare la inregistrare!"); }
            finally
            {
                con.Close();
            }
        }

        private void buttonLogare_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.Show();
        }
    }
}
