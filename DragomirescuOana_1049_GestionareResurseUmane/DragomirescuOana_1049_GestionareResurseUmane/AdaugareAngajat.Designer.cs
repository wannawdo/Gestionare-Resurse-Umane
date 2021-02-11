namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class AdaugareAngajat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareAngajat));
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxExperienta = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSalariu = new System.Windows.Forms.TextBox();
            this.textBoxDepartamemt = new System.Windows.Forms.TextBox();
            this.textBoxStudii = new System.Windows.Forms.TextBox();
            this.buttonAdaugaAngajat = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelStudii = new System.Windows.Forms.Label();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.labelSalariu = new System.Windows.Forms.Label();
            this.labelExperienta = new System.Windows.Forms.Label();
            this.labelDataAngajare = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.dateTimePickerDataAng = new System.Windows.Forms.DateTimePicker();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCNP = new System.Windows.Forms.Label();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.cmsFortamareAngajat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.cmsFortamareAngajat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(274, 139);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(200, 20);
            this.textBoxNume.TabIndex = 1;
            // 
            // textBoxExperienta
            // 
            this.textBoxExperienta.Location = new System.Drawing.Point(274, 259);
            this.textBoxExperienta.Name = "textBoxExperienta";
            this.textBoxExperienta.Size = new System.Drawing.Size(200, 20);
            this.textBoxExperienta.TabIndex = 4;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(274, 179);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrenume.TabIndex = 2;
            // 
            // textBoxSalariu
            // 
            this.textBoxSalariu.Location = new System.Drawing.Point(274, 299);
            this.textBoxSalariu.Name = "textBoxSalariu";
            this.textBoxSalariu.Size = new System.Drawing.Size(199, 20);
            this.textBoxSalariu.TabIndex = 5;
            this.textBoxSalariu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalariu_KeyPress);
            // 
            // textBoxDepartamemt
            // 
            this.textBoxDepartamemt.Location = new System.Drawing.Point(274, 339);
            this.textBoxDepartamemt.Name = "textBoxDepartamemt";
            this.textBoxDepartamemt.Size = new System.Drawing.Size(200, 20);
            this.textBoxDepartamemt.TabIndex = 6;
            // 
            // textBoxStudii
            // 
            this.textBoxStudii.Location = new System.Drawing.Point(274, 379);
            this.textBoxStudii.Name = "textBoxStudii";
            this.textBoxStudii.Size = new System.Drawing.Size(200, 20);
            this.textBoxStudii.TabIndex = 7;
            this.textBoxStudii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudii_KeyPress);
            // 
            // buttonAdaugaAngajat
            // 
            this.buttonAdaugaAngajat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdaugaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaAngajat.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaAngajat.ForeColor = System.Drawing.Color.Thistle;
            this.buttonAdaugaAngajat.Location = new System.Drawing.Point(67, 429);
            this.buttonAdaugaAngajat.Name = "buttonAdaugaAngajat";
            this.buttonAdaugaAngajat.Size = new System.Drawing.Size(130, 36);
            this.buttonAdaugaAngajat.TabIndex = 8;
            this.buttonAdaugaAngajat.Text = "&Adauga angajat";
            this.buttonAdaugaAngajat.UseVisualStyleBackColor = false;
            this.buttonAdaugaAngajat.Click += new System.EventHandler(this.buttonAdaugaAngajat_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelNume.Location = new System.Drawing.Point(64, 142);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(54, 17);
            this.labelNume.TabIndex = 11;
            this.labelNume.Text = "Nume:";
            // 
            // labelStudii
            // 
            this.labelStudii.AutoSize = true;
            this.labelStudii.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelStudii.Location = new System.Drawing.Point(64, 382);
            this.labelStudii.Name = "labelStudii";
            this.labelStudii.Size = new System.Drawing.Size(53, 17);
            this.labelStudii.TabIndex = 13;
            this.labelStudii.Text = "Studii:";
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelDepartament.Location = new System.Drawing.Point(64, 342);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(104, 17);
            this.labelDepartament.TabIndex = 14;
            this.labelDepartament.Text = "Departament:";
            // 
            // labelSalariu
            // 
            this.labelSalariu.AutoSize = true;
            this.labelSalariu.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelSalariu.Location = new System.Drawing.Point(64, 302);
            this.labelSalariu.Name = "labelSalariu";
            this.labelSalariu.Size = new System.Drawing.Size(61, 17);
            this.labelSalariu.TabIndex = 15;
            this.labelSalariu.Text = "Salariu:";
            // 
            // labelExperienta
            // 
            this.labelExperienta.AutoSize = true;
            this.labelExperienta.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelExperienta.Location = new System.Drawing.Point(64, 262);
            this.labelExperienta.Name = "labelExperienta";
            this.labelExperienta.Size = new System.Drawing.Size(127, 17);
            this.labelExperienta.TabIndex = 16;
            this.labelExperienta.Text = "Experienta (ani):";
            // 
            // labelDataAngajare
            // 
            this.labelDataAngajare.AutoSize = true;
            this.labelDataAngajare.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelDataAngajare.Location = new System.Drawing.Point(64, 222);
            this.labelDataAngajare.Name = "labelDataAngajare";
            this.labelDataAngajare.Size = new System.Drawing.Size(110, 17);
            this.labelDataAngajare.TabIndex = 17;
            this.labelDataAngajare.Text = "Data angajare:";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelPrenume.Location = new System.Drawing.Point(64, 182);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(76, 17);
            this.labelPrenume.TabIndex = 20;
            this.labelPrenume.Text = "Prenume:";
            // 
            // dateTimePickerDataAng
            // 
            this.dateTimePickerDataAng.Location = new System.Drawing.Point(274, 219);
            this.dateTimePickerDataAng.Name = "dateTimePickerDataAng";
            this.dateTimePickerDataAng.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataAng.TabIndex = 3;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelTitlu.Location = new System.Drawing.Point(189, 48);
            this.labelTitlu.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(119, 21);
            this.labelTitlu.TabIndex = 12;
            this.labelTitlu.Text = "Angajat Nou";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonBack.ForeColor = System.Drawing.Color.Thistle;
            this.buttonBack.Location = new System.Drawing.Point(266, 429);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(208, 36);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Inapoi la meniul principal";
            this.buttonBack.UseMnemonic = false;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelCNP.Location = new System.Drawing.Point(64, 102);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(43, 17);
            this.labelCNP.TabIndex = 35;
            this.labelCNP.Text = "CNP:";
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.ContextMenuStrip = this.cmsFortamareAngajat;
            this.textBoxCNP.Location = new System.Drawing.Point(274, 99);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(200, 20);
            this.textBoxCNP.TabIndex = 0;
            this.textBoxCNP.Click += new System.EventHandler(this.textBoxCNP_Click);
            this.textBoxCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCNP_KeyPress);
            this.textBoxCNP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCNP_Validating);
            // 
            // cmsFortamareAngajat
            // 
            this.cmsFortamareAngajat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.culoareToolStripMenuItem});
            this.cmsFortamareAngajat.Name = "cmsFortamareAngajat";
            this.cmsFortamareAngajat.Size = new System.Drawing.Size(116, 48);
            this.cmsFortamareAngajat.Text = "Formatare";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.culoareToolStripMenuItem.Text = "Culoare";
            this.culoareToolStripMenuItem.Click += new System.EventHandler(this.culoareToolStripMenuItem_Click);
            // 
            // epCNP
            // 
            this.epCNP.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(404, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-78, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 136);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // logOut1
            // 
            this.logOut1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.logOut1.Location = new System.Drawing.Point(390, 472);
            this.logOut1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 11;
            // 
            // AdaugareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(522, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.dateTimePickerDataAng);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelDataAngajare);
            this.Controls.Add(this.labelExperienta);
            this.Controls.Add(this.labelSalariu);
            this.Controls.Add(this.labelDepartament);
            this.Controls.Add(this.labelStudii);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.buttonAdaugaAngajat);
            this.Controls.Add(this.textBoxStudii);
            this.Controls.Add(this.textBoxDepartamemt);
            this.Controls.Add(this.textBoxSalariu);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxExperienta);
            this.Controls.Add(this.textBoxNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdaugareAngajat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.cmsFortamareAngajat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxExperienta;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxSalariu;
        private System.Windows.Forms.TextBox textBoxDepartamemt;
        private System.Windows.Forms.TextBox textBoxStudii;
        private System.Windows.Forms.Button buttonAdaugaAngajat;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelStudii;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.Label labelSalariu;
        private System.Windows.Forms.Label labelExperienta;
        private System.Windows.Forms.Label labelDataAngajare;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAng;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.ErrorProvider epCNP;
        private System.Windows.Forms.ContextMenuStrip cmsFortamareAngajat;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private LogOut logOut1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

