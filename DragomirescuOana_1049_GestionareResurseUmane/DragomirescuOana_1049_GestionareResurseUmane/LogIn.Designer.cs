namespace DragomirescuOana_1049_GestionareResurseUmane
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.button1 = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogare = new System.Windows.Forms.Button();
            this.labelBineAiVenit = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(273, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Iesire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUser.Location = new System.Drawing.Point(38, 105);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(57, 21);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User:";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.Transparent;
            this.labelParola.Font = new System.Drawing.Font("Rockwell", 14F);
            this.labelParola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelParola.Location = new System.Drawing.Point(38, 150);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(72, 21);
            this.labelParola.TabIndex = 10;
            this.labelParola.Text = "Parola:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.Thistle;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUser.Font = new System.Drawing.Font("Rockwell", 14F);
            this.tbUser.Location = new System.Drawing.Point(138, 97);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(188, 29);
            this.tbUser.TabIndex = 0;
            // 
            // tbParola
            // 
            this.tbParola.BackColor = System.Drawing.Color.Thistle;
            this.tbParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParola.Font = new System.Drawing.Font("Rockwell", 14F);
            this.tbParola.Location = new System.Drawing.Point(138, 142);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(188, 29);
            this.tbParola.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonLogare);
            this.panel1.Controls.Add(this.labelBineAiVenit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Controls.Add(this.tbParola);
            this.panel1.Controls.Add(this.labelParola);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 370);
            this.panel1.TabIndex = 14;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Thistle;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Rockwell", 7F);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegister.Location = new System.Drawing.Point(257, 218);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(69, 26);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Inregistrare";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogare
            // 
            this.buttonLogare.BackColor = System.Drawing.Color.Thistle;
            this.buttonLogare.FlatAppearance.BorderSize = 0;
            this.buttonLogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogare.Font = new System.Drawing.Font("Rockwell", 14F);
            this.buttonLogare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogare.Location = new System.Drawing.Point(235, 177);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(91, 35);
            this.buttonLogare.TabIndex = 2;
            this.buttonLogare.Text = "Logare";
            this.buttonLogare.UseVisualStyleBackColor = false;
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // labelBineAiVenit
            // 
            this.labelBineAiVenit.AutoSize = true;
            this.labelBineAiVenit.Font = new System.Drawing.Font("Yu Gothic", 34F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBineAiVenit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBineAiVenit.Location = new System.Drawing.Point(17, 10);
            this.labelBineAiVenit.Name = "labelBineAiVenit";
            this.labelBineAiVenit.Size = new System.Drawing.Size(241, 59);
            this.labelBineAiVenit.TabIndex = 14;
            this.labelBineAiVenit.Text = "Bun venit!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(372, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.Label labelBineAiVenit;
        private System.Windows.Forms.Button buttonRegister;
    }
}