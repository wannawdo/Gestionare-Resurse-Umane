namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class VizualizareCursuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareCursuri));
            this.bAdaugaCurs = new System.Windows.Forms.Button();
            this.lvCursuri = new System.Windows.Forms.ListView();
            this.chidCurs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDenumireCurs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chenumireDepartament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNrOre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDateDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdaugaCurs
            // 
            this.bAdaugaCurs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdaugaCurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdaugaCurs.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.bAdaugaCurs.ForeColor = System.Drawing.Color.Thistle;
            this.bAdaugaCurs.Location = new System.Drawing.Point(233, 426);
            this.bAdaugaCurs.Margin = new System.Windows.Forms.Padding(2);
            this.bAdaugaCurs.Name = "bAdaugaCurs";
            this.bAdaugaCurs.Size = new System.Drawing.Size(144, 49);
            this.bAdaugaCurs.TabIndex = 1;
            this.bAdaugaCurs.Text = "Inapoi la meniul principal";
            this.bAdaugaCurs.UseVisualStyleBackColor = false;
            this.bAdaugaCurs.Click += new System.EventHandler(this.bAdaugaCurs_Click);
            // 
            // lvCursuri
            // 
            this.lvCursuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chidCurs,
            this.chDenumireCurs,
            this.chenumireDepartament,
            this.chNrOre});
            this.lvCursuri.Font = new System.Drawing.Font("Rockwell", 9F);
            this.lvCursuri.HideSelection = false;
            this.lvCursuri.Location = new System.Drawing.Point(51, 90);
            this.lvCursuri.Margin = new System.Windows.Forms.Padding(2);
            this.lvCursuri.Name = "lvCursuri";
            this.lvCursuri.Size = new System.Drawing.Size(501, 316);
            this.lvCursuri.TabIndex = 0;
            this.lvCursuri.UseCompatibleStateImageBehavior = false;
            this.lvCursuri.View = System.Windows.Forms.View.Details;
            // 
            // chidCurs
            // 
            this.chidCurs.Text = "ID Curs";
            this.chidCurs.Width = 76;
            // 
            // chDenumireCurs
            // 
            this.chDenumireCurs.Text = "Denumire Curs";
            this.chDenumireCurs.Width = 162;
            // 
            // chenumireDepartament
            // 
            this.chenumireDepartament.Text = "Denumire Departament";
            this.chenumireDepartament.Width = 153;
            // 
            // chNrOre
            // 
            this.chNrOre.Text = "Durata (ore)";
            this.chNrOre.Width = 95;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 25);
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
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // labelCurs
            // 
            this.labelCurs.AutoSize = true;
            this.labelCurs.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelCurs.Location = new System.Drawing.Point(243, 51);
            this.labelCurs.Name = "labelCurs";
            this.labelCurs.Size = new System.Drawing.Size(77, 21);
            this.labelCurs.TabIndex = 3;
            this.labelCurs.Text = "Cursuri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(479, 0);
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
            this.logOut1.Location = new System.Drawing.Point(479, 456);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 47);
            this.logOut1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-38, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 133);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // VizualizareCursuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(605, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCurs);
            this.Controls.Add(this.bAdaugaCurs);
            this.Controls.Add(this.lvCursuri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VizualizareCursuri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareCursuri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdaugaCurs;
        private System.Windows.Forms.ListView lvCursuri;
        private System.Windows.Forms.ColumnHeader chidCurs;
        private System.Windows.Forms.ColumnHeader chDenumireCurs;
        private System.Windows.Forms.ColumnHeader chenumireDepartament;
        private System.Windows.Forms.ColumnHeader chNrOre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireDateDinFisierToolStripMenuItem;
        private System.Windows.Forms.Label labelCurs;
        private System.Windows.Forms.Button button1;
        private LogOut logOut1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}