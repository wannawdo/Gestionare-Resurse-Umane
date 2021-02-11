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
    public partial class ToDoList : Form
    {
        int y = 10;
        public ToDoList()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None; 
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
 
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
               if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();         
            Graphics g = Graphics.FromHwnd(panel1.Handle);         
            g.DrawString(text, this.Font, new SolidBrush(Color.Black), 10, y);
            y += 20;
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
            }
            if (y > panel1.Height)
            {   
                MessageBox.Show("Ai ajuns la numarul maxim de cursuri. Nu mai poti adauga altele.");
                panel1.Invalidate();
                y = 10;
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
    }
}
