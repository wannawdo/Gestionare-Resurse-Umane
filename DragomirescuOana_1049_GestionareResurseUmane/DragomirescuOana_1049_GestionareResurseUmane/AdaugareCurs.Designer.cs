namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class AdaugareCurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareCurs));
            this.labelDenumireCurs = new System.Windows.Forms.Label();
            this.labelDenumireDepartament = new System.Windows.Forms.Label();
            this.labelnrOre = new System.Windows.Forms.Label();
            this.labelIDCurs = new System.Windows.Forms.Label();
            this.textBoxNrOre = new System.Windows.Forms.TextBox();
            this.textBoxDenumireCurs = new System.Windows.Forms.TextBox();
            this.textBoxdenumireDepartament = new System.Windows.Forms.TextBox();
            this.textBoxIDCurs = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdaugaCurs = new System.Windows.Forms.Button();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.epDurataCurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            ((System.ComponentModel.ISupportInitialize)(this.epDurataCurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDenumireCurs
            // 
            this.labelDenumireCurs.AutoSize = true;
            this.labelDenumireCurs.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelDenumireCurs.Location = new System.Drawing.Point(56, 148);
            this.labelDenumireCurs.Name = "labelDenumireCurs";
            this.labelDenumireCurs.Size = new System.Drawing.Size(83, 17);
            this.labelDenumireCurs.TabIndex = 30;
            this.labelDenumireCurs.Text = "Denumire:";
            // 
            // labelDenumireDepartament
            // 
            this.labelDenumireDepartament.AutoSize = true;
            this.labelDenumireDepartament.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelDenumireDepartament.Location = new System.Drawing.Point(56, 188);
            this.labelDenumireDepartament.Name = "labelDenumireDepartament";
            this.labelDenumireDepartament.Size = new System.Drawing.Size(104, 17);
            this.labelDenumireDepartament.TabIndex = 28;
            this.labelDenumireDepartament.Text = "Departament:";
            // 
            // labelnrOre
            // 
            this.labelnrOre.AutoSize = true;
            this.labelnrOre.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelnrOre.Location = new System.Drawing.Point(56, 228);
            this.labelnrOre.Name = "labelnrOre";
            this.labelnrOre.Size = new System.Drawing.Size(99, 17);
            this.labelnrOre.TabIndex = 27;
            this.labelnrOre.Text = "Durata (ore):";
            // 
            // labelIDCurs
            // 
            this.labelIDCurs.AutoSize = true;
            this.labelIDCurs.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelIDCurs.Location = new System.Drawing.Point(56, 108);
            this.labelIDCurs.Name = "labelIDCurs";
            this.labelIDCurs.Size = new System.Drawing.Size(28, 17);
            this.labelIDCurs.TabIndex = 26;
            this.labelIDCurs.Text = "ID:";
            // 
            // textBoxNrOre
            // 
            this.textBoxNrOre.Location = new System.Drawing.Point(259, 228);
            this.textBoxNrOre.Name = "textBoxNrOre";
            this.textBoxNrOre.Size = new System.Drawing.Size(199, 20);
            this.textBoxNrOre.TabIndex = 3;
            this.textBoxNrOre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNrOre_Validating);
            // 
            // textBoxDenumireCurs
            // 
            this.textBoxDenumireCurs.Location = new System.Drawing.Point(259, 148);
            this.textBoxDenumireCurs.Name = "textBoxDenumireCurs";
            this.textBoxDenumireCurs.Size = new System.Drawing.Size(200, 20);
            this.textBoxDenumireCurs.TabIndex = 1;
            // 
            // textBoxdenumireDepartament
            // 
            this.textBoxdenumireDepartament.Location = new System.Drawing.Point(259, 188);
            this.textBoxdenumireDepartament.Name = "textBoxdenumireDepartament";
            this.textBoxdenumireDepartament.Size = new System.Drawing.Size(200, 20);
            this.textBoxdenumireDepartament.TabIndex = 2;
            // 
            // textBoxIDCurs
            // 
            this.textBoxIDCurs.Location = new System.Drawing.Point(259, 108);
            this.textBoxIDCurs.Name = "textBoxIDCurs";
            this.textBoxIDCurs.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDCurs.TabIndex = 0;
            this.textBoxIDCurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDCurs_KeyPress);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonBack.ForeColor = System.Drawing.Color.Thistle;
            this.buttonBack.Location = new System.Drawing.Point(252, 292);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(207, 36);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Inapoi la meniul principal";
            this.buttonBack.UseMnemonic = false;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdaugaCurs
            // 
            this.buttonAdaugaCurs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdaugaCurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaCurs.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonAdaugaCurs.ForeColor = System.Drawing.Color.Thistle;
            this.buttonAdaugaCurs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdaugaCurs.Location = new System.Drawing.Point(59, 292);
            this.buttonAdaugaCurs.Name = "buttonAdaugaCurs";
            this.buttonAdaugaCurs.Size = new System.Drawing.Size(136, 36);
            this.buttonAdaugaCurs.TabIndex = 4;
            this.buttonAdaugaCurs.Text = "&Adauga curs";
            this.buttonAdaugaCurs.UseVisualStyleBackColor = false;
            this.buttonAdaugaCurs.Click += new System.EventHandler(this.buttonAdaugaCurs_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitlu.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelTitlu.Location = new System.Drawing.Point(202, 42);
            this.labelTitlu.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(93, 21);
            this.labelTitlu.TabIndex = 36;
            this.labelTitlu.Text = "Curs Nou";
            // 
            // epDurataCurs
            // 
            this.epDurataCurs.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(390, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-81, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 136);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(390, 334);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 6;
            // 
            // AdaugareCurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(511, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdaugaCurs);
            this.Controls.Add(this.labelDenumireCurs);
            this.Controls.Add(this.labelDenumireDepartament);
            this.Controls.Add(this.labelnrOre);
            this.Controls.Add(this.labelIDCurs);
            this.Controls.Add(this.textBoxNrOre);
            this.Controls.Add(this.textBoxDenumireCurs);
            this.Controls.Add(this.textBoxdenumireDepartament);
            this.Controls.Add(this.textBoxIDCurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdaugareCurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugareCurs";
            ((System.ComponentModel.ISupportInitialize)(this.epDurataCurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDenumireCurs;
        private System.Windows.Forms.Label labelDenumireDepartament;
        private System.Windows.Forms.Label labelnrOre;
        private System.Windows.Forms.Label labelIDCurs;
        private System.Windows.Forms.TextBox textBoxNrOre;
        private System.Windows.Forms.TextBox textBoxDenumireCurs;
        private System.Windows.Forms.TextBox textBoxdenumireDepartament;
        private System.Windows.Forms.TextBox textBoxIDCurs;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdaugaCurs;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.ErrorProvider epDurataCurs;
        private System.Windows.Forms.Button button1;
        private LogOut logOut1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}