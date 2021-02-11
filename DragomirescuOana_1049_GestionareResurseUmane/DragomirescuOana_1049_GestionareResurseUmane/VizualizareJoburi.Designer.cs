namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class lvJoburi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvJoburi));
            this.bAdaugaJob = new System.Windows.Forms.Button();
            this.lviJoburi = new System.Windows.Forms.ListView();
            this.chDenumireJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpNecesara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cheSalariuMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalariulMinim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDateDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pringtPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelJoburi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdaugaJob
            // 
            this.bAdaugaJob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdaugaJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdaugaJob.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.bAdaugaJob.ForeColor = System.Drawing.Color.Thistle;
            this.bAdaugaJob.Location = new System.Drawing.Point(243, 427);
            this.bAdaugaJob.Margin = new System.Windows.Forms.Padding(2);
            this.bAdaugaJob.Name = "bAdaugaJob";
            this.bAdaugaJob.Size = new System.Drawing.Size(144, 49);
            this.bAdaugaJob.TabIndex = 1;
            this.bAdaugaJob.Text = "Inapoi &la meniul principal";
            this.bAdaugaJob.UseVisualStyleBackColor = false;
            this.bAdaugaJob.Click += new System.EventHandler(this.bAdaugaJob_Click);
            // 
            // lviJoburi
            // 
            this.lviJoburi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDenumireJob,
            this.chExpNecesara,
            this.cheSalariuMax,
            this.chSalariulMinim});
            this.lviJoburi.Font = new System.Drawing.Font("Rockwell", 9F);
            this.lviJoburi.HideSelection = false;
            this.lviJoburi.Location = new System.Drawing.Point(35, 95);
            this.lviJoburi.Margin = new System.Windows.Forms.Padding(2);
            this.lviJoburi.Name = "lviJoburi";
            this.lviJoburi.Size = new System.Drawing.Size(562, 316);
            this.lviJoburi.TabIndex = 0;
            this.lviJoburi.UseCompatibleStateImageBehavior = false;
            this.lviJoburi.View = System.Windows.Forms.View.Details;
            // 
            // chDenumireJob
            // 
            this.chDenumireJob.Text = "Denumire";
            this.chDenumireJob.Width = 174;
            // 
            // chExpNecesara
            // 
            this.chExpNecesara.Text = "Experienta Necesara";
            this.chExpNecesara.Width = 138;
            // 
            // cheSalariuMax
            // 
            this.cheSalariuMax.Text = "Salariul Maxim";
            this.cheSalariuMax.Width = 145;
            // 
            // chSalariulMinim
            // 
            this.chSalariulMinim.Text = "Salariul Minim";
            this.chSalariulMinim.Width = 95;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem,
            this.pringtPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateInFisierToolStripMenuItem,
            this.citireDateDinFisierToolStripMenuItem});
            this.optiuniToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // salvareDateInFisierToolStripMenuItem
            // 
            this.salvareDateInFisierToolStripMenuItem.Name = "salvareDateInFisierToolStripMenuItem";
            this.salvareDateInFisierToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.salvareDateInFisierToolStripMenuItem.Text = "Salvare date in fisier";
            this.salvareDateInFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareDateInFisierToolStripMenuItem_Click);
            // 
            // citireDateDinFisierToolStripMenuItem
            // 
            this.citireDateDinFisierToolStripMenuItem.Name = "citireDateDinFisierToolStripMenuItem";
            this.citireDateDinFisierToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.citireDateDinFisierToolStripMenuItem.Text = "Citire date din fisier";
            this.citireDateDinFisierToolStripMenuItem.Click += new System.EventHandler(this.citireDateDinFisierToolStripMenuItem_Click);
            // 
            // pringtPreviewToolStripMenuItem
            // 
            this.pringtPreviewToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.pringtPreviewToolStripMenuItem.Name = "pringtPreviewToolStripMenuItem";
            this.pringtPreviewToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.pringtPreviewToolStripMenuItem.Text = "Print Preview";
            this.pringtPreviewToolStripMenuItem.Click += new System.EventHandler(this.pringtPreviewToolStripMenuItem_Click);
            // 
            // labelJoburi
            // 
            this.labelJoburi.AutoSize = true;
            this.labelJoburi.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelJoburi.Location = new System.Drawing.Point(272, 54);
            this.labelJoburi.Name = "labelJoburi";
            this.labelJoburi.Size = new System.Drawing.Size(64, 21);
            this.labelJoburi.TabIndex = 3;
            this.labelJoburi.Text = "Joburi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(520, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(520, 440);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-68, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lvJoburi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(633, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelJoburi);
            this.Controls.Add(this.bAdaugaJob);
            this.Controls.Add(this.lviJoburi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lvJoburi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareJoburi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdaugaJob;
        private System.Windows.Forms.ListView lviJoburi;
        private System.Windows.Forms.ColumnHeader chDenumireJob;
        private System.Windows.Forms.ColumnHeader chExpNecesara;
        private System.Windows.Forms.ColumnHeader cheSalariuMax;
        private System.Windows.Forms.ColumnHeader chSalariulMinim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireDateDinFisierToolStripMenuItem;
        private System.Windows.Forms.Label labelJoburi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem pringtPreviewToolStripMenuItem;
        private LogOut logOut1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}