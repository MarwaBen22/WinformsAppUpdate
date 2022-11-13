
namespace GRHApp.Forms
{
    partial class ResetPW1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPW1));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pcbPassword = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pcbConfirmPW = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pcbPW = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCheckPW = new System.Windows.Forms.Label();
            this.lblHiddenEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfirmPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPW)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(336, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(5, 454);
            this.pnlRight.TabIndex = 8;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(5, 454);
            this.pnlLeft.TabIndex = 9;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 459);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(341, 5);
            this.pnlBottom.TabIndex = 10;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(341, 5);
            this.pnlTop.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(53, 29);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(235, 20);
            this.lblNewPassword.TabIndex = 11;
            this.lblNewPassword.Text = "Créer un nouveau mot de passe";
            // 
            // pcbPassword
            // 
            this.pcbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pcbPassword.Image")));
            this.pcbPassword.Location = new System.Drawing.Point(120, 70);
            this.pcbPassword.Name = "pcbPassword";
            this.pcbPassword.Size = new System.Drawing.Size(100, 100);
            this.pcbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPassword.TabIndex = 12;
            this.pcbPassword.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(55, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 32);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Votre mot de passe doit etre différent \r\nDu mot de passe utilisé précédement";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbConfirmPW
            // 
            this.pcbConfirmPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pcbConfirmPW.Image = ((System.Drawing.Image)(resources.GetObject("pcbConfirmPW.Image")));
            this.pcbConfirmPW.Location = new System.Drawing.Point(57, 319);
            this.pcbConfirmPW.Name = "pcbConfirmPW";
            this.pcbConfirmPW.Size = new System.Drawing.Size(25, 25);
            this.pcbConfirmPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbConfirmPW.TabIndex = 17;
            this.pcbConfirmPW.TabStop = false;
            this.pcbConfirmPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbConfirmPW_MouseDown);
            this.pcbConfirmPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbConfirmPW_MouseUp);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(84, 322);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(199, 19);
            this.txtConfirmPassword.TabIndex = 16;
            this.txtConfirmPassword.Text = "   Confirmer le mot de passe";
            this.txtConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtConfirmPassword_MouseClick);
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // pcbPW
            // 
            this.pcbPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pcbPW.Image = ((System.Drawing.Image)(resources.GetObject("pcbPW.Image")));
            this.pcbPW.Location = new System.Drawing.Point(57, 274);
            this.pcbPW.Name = "pcbPW";
            this.pcbPW.Size = new System.Drawing.Size(25, 25);
            this.pcbPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPW.TabIndex = 15;
            this.pcbPW.TabStop = false;
            this.pcbPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbPW_MouseDown);
            this.pcbPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbPW_MouseUp);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtPassword.Location = new System.Drawing.Point(84, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 19);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "   Nouveau mot de passe";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnSave.Location = new System.Drawing.Point(70, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCheckPW
            // 
            this.lblCheckPW.AutoSize = true;
            this.lblCheckPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckPW.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPW.Location = new System.Drawing.Point(85, 346);
            this.lblCheckPW.Name = "lblCheckPW";
            this.lblCheckPW.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPW.TabIndex = 19;
            // 
            // lblHiddenEmail
            // 
            this.lblHiddenEmail.AutoSize = true;
            this.lblHiddenEmail.Location = new System.Drawing.Point(153, 249);
            this.lblHiddenEmail.Name = "lblHiddenEmail";
            this.lblHiddenEmail.Size = new System.Drawing.Size(35, 13);
            this.lblHiddenEmail.TabIndex = 20;
            this.lblHiddenEmail.Text = "label1";
            this.lblHiddenEmail.Visible = false;
            // 
            // ResetPW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 464);
            this.Controls.Add(this.lblHiddenEmail);
            this.Controls.Add(this.lblCheckPW);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pcbConfirmPW);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.pcbPW);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pcbPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPW1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPW1";
            this.Load += new System.EventHandler(this.ResetPW1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConfirmPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.PictureBox pcbPassword;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pcbConfirmPW;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pcbPW;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCheckPW;
        public System.Windows.Forms.Label lblHiddenEmail;
    }
}