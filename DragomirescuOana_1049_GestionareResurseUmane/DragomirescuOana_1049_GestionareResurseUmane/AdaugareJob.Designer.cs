namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class AdaugareJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareJob));
            this.labelDenuireJob = new System.Windows.Forms.Label();
            this.labelExperientaNecesara = new System.Windows.Forms.Label();
            this.labelSalariuMax = new System.Windows.Forms.Label();
            this.textBoxSalariuMaxim = new System.Windows.Forms.TextBox();
            this.textBoxExperienta = new System.Windows.Forms.TextBox();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdaugaJob = new System.Windows.Forms.Button();
            this.labelSalariuMin = new System.Windows.Forms.Label();
            this.textBoxSalariuMinim = new System.Windows.Forms.TextBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.epDenumireJob = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumireJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDenuireJob
            // 
            this.labelDenuireJob.AutoSize = true;
            this.labelDenuireJob.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelDenuireJob.Location = new System.Drawing.Point(48, 117);
            this.labelDenuireJob.Name = "labelDenuireJob";
            this.labelDenuireJob.Size = new System.Drawing.Size(83, 17);
            this.labelDenuireJob.TabIndex = 22;
            this.labelDenuireJob.Text = "Denumire:";
            // 
            // labelExperientaNecesara
            // 
            this.labelExperientaNecesara.AutoSize = true;
            this.labelExperientaNecesara.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelExperientaNecesara.Location = new System.Drawing.Point(48, 157);
            this.labelExperientaNecesara.Name = "labelExperientaNecesara";
            this.labelExperientaNecesara.Size = new System.Drawing.Size(127, 17);
            this.labelExperientaNecesara.TabIndex = 21;
            this.labelExperientaNecesara.Text = "Experienta (ani):";
            // 
            // labelSalariuMax
            // 
            this.labelSalariuMax.AutoSize = true;
            this.labelSalariuMax.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelSalariuMax.Location = new System.Drawing.Point(48, 197);
            this.labelSalariuMax.Name = "labelSalariuMax";
            this.labelSalariuMax.Size = new System.Drawing.Size(112, 17);
            this.labelSalariuMax.TabIndex = 20;
            this.labelSalariuMax.Text = "Salariu maxim:";
            // 
            // textBoxSalariuMaxim
            // 
            this.textBoxSalariuMaxim.Location = new System.Drawing.Point(253, 197);
            this.textBoxSalariuMaxim.Name = "textBoxSalariuMaxim";
            this.textBoxSalariuMaxim.Size = new System.Drawing.Size(200, 20);
            this.textBoxSalariuMaxim.TabIndex = 2;
            this.textBoxSalariuMaxim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalariuMaxim_KeyPress);
            // 
            // textBoxExperienta
            // 
            this.textBoxExperienta.Location = new System.Drawing.Point(253, 157);
            this.textBoxExperienta.Name = "textBoxExperienta";
            this.textBoxExperienta.Size = new System.Drawing.Size(199, 20);
            this.textBoxExperienta.TabIndex = 1;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(253, 117);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(200, 20);
            this.textBoxDenumire.TabIndex = 0;
            this.textBoxDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDenumire_Validating);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonBack.ForeColor = System.Drawing.Color.Thistle;
            this.buttonBack.Location = new System.Drawing.Point(245, 301);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(208, 38);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Inapoi la meniul principal";
            this.buttonBack.UseMnemonic = false;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdaugaJob
            // 
            this.buttonAdaugaJob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdaugaJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdaugaJob.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonAdaugaJob.ForeColor = System.Drawing.Color.Thistle;
            this.buttonAdaugaJob.Location = new System.Drawing.Point(51, 301);
            this.buttonAdaugaJob.Name = "buttonAdaugaJob";
            this.buttonAdaugaJob.Size = new System.Drawing.Size(134, 38);
            this.buttonAdaugaJob.TabIndex = 4;
            this.buttonAdaugaJob.Text = "&Adauga job";
            this.buttonAdaugaJob.UseVisualStyleBackColor = false;
            this.buttonAdaugaJob.Click += new System.EventHandler(this.buttonAdaugaJob_Click);
            // 
            // labelSalariuMin
            // 
            this.labelSalariuMin.AutoSize = true;
            this.labelSalariuMin.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.labelSalariuMin.Location = new System.Drawing.Point(48, 237);
            this.labelSalariuMin.Name = "labelSalariuMin";
            this.labelSalariuMin.Size = new System.Drawing.Size(110, 17);
            this.labelSalariuMin.TabIndex = 39;
            this.labelSalariuMin.Text = "Salariu minim:";
            // 
            // textBoxSalariuMinim
            // 
            this.textBoxSalariuMinim.Location = new System.Drawing.Point(253, 237);
            this.textBoxSalariuMinim.Name = "textBoxSalariuMinim";
            this.textBoxSalariuMinim.Size = new System.Drawing.Size(199, 20);
            this.textBoxSalariuMinim.TabIndex = 3;
            this.textBoxSalariuMinim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalariuMinim_KeyPress);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelTitlu.Location = new System.Drawing.Point(191, 47);
            this.labelTitlu.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(80, 21);
            this.labelTitlu.TabIndex = 40;
            this.labelTitlu.Text = "Job Nou";
            // 
            // epDenumireJob
            // 
            this.epDenumireJob.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(366, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(366, 345);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 149);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // AdaugareJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(513, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.labelSalariuMin);
            this.Controls.Add(this.textBoxSalariuMinim);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdaugaJob);
            this.Controls.Add(this.labelDenuireJob);
            this.Controls.Add(this.labelExperientaNecesara);
            this.Controls.Add(this.labelSalariuMax);
            this.Controls.Add(this.textBoxSalariuMaxim);
            this.Controls.Add(this.textBoxExperienta);
            this.Controls.Add(this.textBoxDenumire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdaugareJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugareJob";
            ((System.ComponentModel.ISupportInitialize)(this.epDenumireJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDenuireJob;
        private System.Windows.Forms.Label labelExperientaNecesara;
        private System.Windows.Forms.Label labelSalariuMax;
        private System.Windows.Forms.TextBox textBoxSalariuMaxim;
        private System.Windows.Forms.TextBox textBoxExperienta;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdaugaJob;
        private System.Windows.Forms.Label labelSalariuMin;
        private System.Windows.Forms.TextBox textBoxSalariuMinim;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.ErrorProvider epDenumireJob;
        private System.Windows.Forms.Button button1;
        private LogOut logOut1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}