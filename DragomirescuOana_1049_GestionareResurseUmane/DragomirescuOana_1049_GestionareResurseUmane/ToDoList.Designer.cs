namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTextCursuri = new System.Windows.Forms.Label();
            this.labelTextLista = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 14F);
            this.textBox1.Location = new System.Drawing.Point(226, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelText.Location = new System.Drawing.Point(33, 65);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(156, 17);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Scrie aici cursul dorit ->";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Font = new System.Drawing.Font("Rockwell", 14F);
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(226, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 146);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelTextCursuri
            // 
            this.labelTextCursuri.AutoSize = true;
            this.labelTextCursuri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextCursuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextCursuri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTextCursuri.Location = new System.Drawing.Point(29, 153);
            this.labelTextCursuri.Name = "labelTextCursuri";
            this.labelTextCursuri.Size = new System.Drawing.Size(164, 17);
            this.labelTextCursuri.TabIndex = 3;
            this.labelTextCursuri.Text = "Aici duci cursul pe care il";
            // 
            // labelTextLista
            // 
            this.labelTextLista.AutoSize = true;
            this.labelTextLista.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTextLista.Location = new System.Drawing.Point(29, 170);
            this.labelTextLista.Name = "labelTextLista";
            this.labelTextLista.Size = new System.Drawing.Size(181, 17);
            this.labelTextLista.TabIndex = 4;
            this.labelTextLista.Text = " vrei pentru a face o lista ->";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(368, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.Thistle;
            this.buttonInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInapoi.Font = new System.Drawing.Font("Rockwell", 14F);
            this.buttonInapoi.Location = new System.Drawing.Point(341, 285);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(91, 32);
            this.buttonInapoi.TabIndex = 2;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(357, 400);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 3;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 435);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextLista);
            this.Controls.Add(this.labelTextCursuri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTextCursuri;
        private System.Windows.Forms.Label labelTextLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInapoi;
        private LogOut logOut1;
    }
}