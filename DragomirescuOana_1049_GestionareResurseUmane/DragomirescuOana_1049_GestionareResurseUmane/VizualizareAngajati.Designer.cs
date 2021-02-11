namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class VizualizareAngajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareAngajati));
            this.bAdaugaAngajat = new System.Windows.Forms.Button();
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.chCnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataAng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExperienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalariu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStudii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsVizualizareAngajati = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMOptiuniAngajat = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDateDinFisierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAngajati = new System.Windows.Forms.Label();
            this.buttonPersonalizeaza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsVizualizareAngajati.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdaugaAngajat
            // 
            this.bAdaugaAngajat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdaugaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdaugaAngajat.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.bAdaugaAngajat.ForeColor = System.Drawing.Color.Thistle;
            this.bAdaugaAngajat.Location = new System.Drawing.Point(408, 413);
            this.bAdaugaAngajat.Margin = new System.Windows.Forms.Padding(2);
            this.bAdaugaAngajat.Name = "bAdaugaAngajat";
            this.bAdaugaAngajat.Size = new System.Drawing.Size(205, 38);
            this.bAdaugaAngajat.TabIndex = 2;
            this.bAdaugaAngajat.Text = "Inapoi la meniul principal";
            this.bAdaugaAngajat.UseVisualStyleBackColor = false;
            this.bAdaugaAngajat.Click += new System.EventHandler(this.bAdaugaAngajat_Click);
            // 
            // lvAngajati
            // 
            this.lvAngajati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCnp,
            this.chNume,
            this.chPenume,
            this.chDataAng,
            this.chExperienta,
            this.chSalariu,
            this.chDepartament,
            this.chStudii});
            this.lvAngajati.ContextMenuStrip = this.cmsVizualizareAngajati;
            this.lvAngajati.Font = new System.Drawing.Font("Rockwell", 9F);
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(29, 81);
            this.lvAngajati.Margin = new System.Windows.Forms.Padding(2);
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(702, 316);
            this.lvAngajati.TabIndex = 0;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.View = System.Windows.Forms.View.Details;
            // 
            // chCnp
            // 
            this.chCnp.Text = "CNP";
            this.chCnp.Width = 97;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 100;
            // 
            // chPenume
            // 
            this.chPenume.Text = "Prenume";
            this.chPenume.Width = 83;
            // 
            // chDataAng
            // 
            this.chDataAng.Text = "Data Angajare";
            this.chDataAng.Width = 95;
            // 
            // chExperienta
            // 
            this.chExperienta.Text = "Experienta";
            this.chExperienta.Width = 88;
            // 
            // chSalariu
            // 
            this.chSalariu.Text = "Salariu";
            // 
            // chDepartament
            // 
            this.chDepartament.Text = "Departament";
            this.chDepartament.Width = 87;
            // 
            // chStudii
            // 
            this.chStudii.Text = "Studii";
            this.chStudii.Width = 87;
            // 
            // cmsVizualizareAngajati
            // 
            this.cmsVizualizareAngajati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.culoareToolStripMenuItem});
            this.cmsVizualizareAngajati.Name = "cmsVizualizareAngajati";
            this.cmsVizualizareAngajati.Size = new System.Drawing.Size(116, 48);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMOptiuniAngajat,
            this.printPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMOptiuniAngajat
            // 
            this.TSMOptiuniAngajat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireDateDinFisierToolStripMenuItem1,
            this.salvareDateInFisierToolStripMenuItem});
            this.TSMOptiuniAngajat.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.TSMOptiuniAngajat.Name = "TSMOptiuniAngajat";
            this.TSMOptiuniAngajat.Size = new System.Drawing.Size(74, 21);
            this.TSMOptiuniAngajat.Text = "Optiuni";
            // 
            // citireDateDinFisierToolStripMenuItem1
            // 
            this.citireDateDinFisierToolStripMenuItem1.Name = "citireDateDinFisierToolStripMenuItem1";
            this.citireDateDinFisierToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.citireDateDinFisierToolStripMenuItem1.Text = "Citire date din fisier";
            this.citireDateDinFisierToolStripMenuItem1.Click += new System.EventHandler(this.citireDateDinFisierToolStripMenuItem1_Click);
            // 
            // salvareDateInFisierToolStripMenuItem
            // 
            this.salvareDateInFisierToolStripMenuItem.Name = "salvareDateInFisierToolStripMenuItem";
            this.salvareDateInFisierToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.salvareDateInFisierToolStripMenuItem.Text = "Salvare date in fisier ";
            this.salvareDateInFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareDateInFisierToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // labelAngajati
            // 
            this.labelAngajati.AutoSize = true;
            this.labelAngajati.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelAngajati.Location = new System.Drawing.Point(319, 35);
            this.labelAngajati.Name = "labelAngajati";
            this.labelAngajati.Size = new System.Drawing.Size(84, 21);
            this.labelAngajati.TabIndex = 3;
            this.labelAngajati.Text = "Angajati";
            // 
            // buttonPersonalizeaza
            // 
            this.buttonPersonalizeaza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPersonalizeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalizeaza.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.buttonPersonalizeaza.ForeColor = System.Drawing.Color.Thistle;
            this.buttonPersonalizeaza.Location = new System.Drawing.Point(146, 413);
            this.buttonPersonalizeaza.Name = "buttonPersonalizeaza";
            this.buttonPersonalizeaza.Size = new System.Drawing.Size(132, 38);
            this.buttonPersonalizeaza.TabIndex = 1;
            this.buttonPersonalizeaza.Text = "Personalizeaza";
            this.buttonPersonalizeaza.UseVisualStyleBackColor = false;
            this.buttonPersonalizeaza.Click += new System.EventHandler(this.buttonPersonalizeaza_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(670, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(670, 437);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-38, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 116);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // VizualizareAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(757, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPersonalizeaza);
            this.Controls.Add(this.labelAngajati);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bAdaugaAngajat);
            this.Controls.Add(this.lvAngajati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VizualizareAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareAngajati";
            this.cmsVizualizareAngajati.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdaugaAngajat;
        private System.Windows.Forms.ListView lvAngajati;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCnp;
        private System.Windows.Forms.ColumnHeader chPenume;
        private System.Windows.Forms.ColumnHeader chDataAng;
        private System.Windows.Forms.ColumnHeader chExperienta;
        private System.Windows.Forms.ColumnHeader chSalariu;
        private System.Windows.Forms.ColumnHeader chDepartament;
        private System.Windows.Forms.ColumnHeader chStudii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMOptiuniAngajat;
        private System.Windows.Forms.ToolStripMenuItem citireDateDinFisierToolStripMenuItem1;
        private System.Windows.Forms.Label labelAngajati;
        private System.Windows.Forms.ContextMenuStrip cmsVizualizareAngajati;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.Button buttonPersonalizeaza;
        private System.Windows.Forms.ToolStripMenuItem salvareDateInFisierToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private LogOut logOut1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}