namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class GestionareInformatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionareInformatii));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOut1 = new DragomirescuOana_1049_GestionareResurseUmane.LogOut();
            this.panelSexe = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DragomirescuOana_1049_GestionareResurseUmane.Properties.Resources.icons8_close_window_22;
            this.button1.Location = new System.Drawing.Point(437, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 2;
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
            this.buttonInapoi.Location = new System.Drawing.Point(7, 278);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(108, 38);
            this.buttonInapoi.TabIndex = 0;
            this.buttonInapoi.Text = "Inapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.logOut1);
            this.panel1.Controls.Add(this.buttonInapoi);
            this.panel1.Location = new System.Drawing.Point(383, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 374);
            this.panel1.TabIndex = 12;
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(39, 341);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(101, 42);
            this.logOut1.TabIndex = 1;
            // 
            // panelSexe
            // 
            this.panelSexe.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSexe.Location = new System.Drawing.Point(0, 0);
            this.panelSexe.Name = "panelSexe";
            this.panelSexe.Size = new System.Drawing.Size(384, 374);
            this.panelSexe.TabIndex = 13;
            this.panelSexe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSexe_Paint_1);
            this.panelSexe.Resize += new System.EventHandler(this.panelSexe_Resize_1);
            // 
            // GestionareInformatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.panelSexe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionareInformatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionareInformatii";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Panel panel1;
        private LogOut logOut1;
        private System.Windows.Forms.Panel panelSexe;
    }
}