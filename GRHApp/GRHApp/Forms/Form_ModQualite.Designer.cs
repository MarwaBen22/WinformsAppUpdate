
namespace GRHApp.Forms
{
    partial class Form_ModQualite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModQualite));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnModBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDocForm = new System.Windows.Forms.Button();
            this.btnDocHSE = new System.Windows.Forms.Button();
            this.btnDocCert = new System.Windows.Forms.Button();
            this.btnDocPR = new System.Windows.Forms.Button();
            this.btnDocCO = new System.Windows.Forms.Button();
            this.btnDocMG = new System.Windows.Forms.Button();
            this.btnDocRH = new System.Windows.Forms.Button();
            this.btnDocAM = new System.Windows.Forms.Button();
            this.btnDocDC = new System.Windows.Forms.Button();
            this.btnDocDG = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.pnlTop.Controls.Add(this.btnModBack);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // btnModBack
            // 
            this.btnModBack.FlatAppearance.BorderSize = 0;
            this.btnModBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModBack.Image = ((System.Drawing.Image)(resources.GetObject("btnModBack.Image")));
            this.btnModBack.Location = new System.Drawing.Point(200, 0);
            this.btnModBack.Name = "btnModBack";
            this.btnModBack.Size = new System.Drawing.Size(50, 50);
            this.btnModBack.TabIndex = 6;
            this.btnModBack.UseVisualStyleBackColor = true;
            this.btnModBack.Click += new System.EventHandler(this.btnModBack_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1131, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Système de gestion \r\nde qualité";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1167, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Controls.Add(this.pnlUser);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 681);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnDocForm);
            this.pnlButtons.Controls.Add(this.btnDocHSE);
            this.pnlButtons.Controls.Add(this.btnDocCert);
            this.pnlButtons.Controls.Add(this.btnDocPR);
            this.pnlButtons.Controls.Add(this.btnDocCO);
            this.pnlButtons.Controls.Add(this.btnDocMG);
            this.pnlButtons.Controls.Add(this.btnDocRH);
            this.pnlButtons.Controls.Add(this.btnDocAM);
            this.pnlButtons.Controls.Add(this.btnDocDC);
            this.pnlButtons.Controls.Add(this.btnDocDG);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 75);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 606);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDocForm
            // 
            this.btnDocForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocForm.FlatAppearance.BorderSize = 0;
            this.btnDocForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocForm.Image = ((System.Drawing.Image)(resources.GetObject("btnDocForm.Image")));
            this.btnDocForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocForm.Location = new System.Drawing.Point(0, 400);
            this.btnDocForm.Name = "btnDocForm";
            this.btnDocForm.Size = new System.Drawing.Size(200, 40);
            this.btnDocForm.TabIndex = 18;
            this.btnDocForm.Text = "Formation";
            this.btnDocForm.UseVisualStyleBackColor = true;
            this.btnDocForm.Click += new System.EventHandler(this.btnDocForm_Click);
            // 
            // btnDocHSE
            // 
            this.btnDocHSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocHSE.FlatAppearance.BorderSize = 0;
            this.btnDocHSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocHSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocHSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocHSE.Image = ((System.Drawing.Image)(resources.GetObject("btnDocHSE.Image")));
            this.btnDocHSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocHSE.Location = new System.Drawing.Point(0, 360);
            this.btnDocHSE.Name = "btnDocHSE";
            this.btnDocHSE.Size = new System.Drawing.Size(200, 40);
            this.btnDocHSE.TabIndex = 17;
            this.btnDocHSE.Text = "HSE";
            this.btnDocHSE.UseVisualStyleBackColor = true;
            this.btnDocHSE.Click += new System.EventHandler(this.btnDocHSE_Click);
            // 
            // btnDocCert
            // 
            this.btnDocCert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocCert.FlatAppearance.BorderSize = 0;
            this.btnDocCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocCert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocCert.Image = ((System.Drawing.Image)(resources.GetObject("btnDocCert.Image")));
            this.btnDocCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocCert.Location = new System.Drawing.Point(0, 320);
            this.btnDocCert.Name = "btnDocCert";
            this.btnDocCert.Size = new System.Drawing.Size(200, 40);
            this.btnDocCert.TabIndex = 16;
            this.btnDocCert.Text = "Cert";
            this.btnDocCert.UseVisualStyleBackColor = true;
            this.btnDocCert.Click += new System.EventHandler(this.btnDocCert_Click);
            // 
            // btnDocPR
            // 
            this.btnDocPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocPR.FlatAppearance.BorderSize = 0;
            this.btnDocPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocPR.Image = ((System.Drawing.Image)(resources.GetObject("btnDocPR.Image")));
            this.btnDocPR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocPR.Location = new System.Drawing.Point(0, 280);
            this.btnDocPR.Name = "btnDocPR";
            this.btnDocPR.Size = new System.Drawing.Size(200, 40);
            this.btnDocPR.TabIndex = 15;
            this.btnDocPR.Text = "PR";
            this.btnDocPR.UseVisualStyleBackColor = true;
            this.btnDocPR.Click += new System.EventHandler(this.btnDocPR_Click);
            // 
            // btnDocCO
            // 
            this.btnDocCO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocCO.FlatAppearance.BorderSize = 0;
            this.btnDocCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocCO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocCO.Image = ((System.Drawing.Image)(resources.GetObject("btnDocCO.Image")));
            this.btnDocCO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocCO.Location = new System.Drawing.Point(0, 240);
            this.btnDocCO.Name = "btnDocCO";
            this.btnDocCO.Size = new System.Drawing.Size(200, 40);
            this.btnDocCO.TabIndex = 14;
            this.btnDocCO.Text = "CO";
            this.btnDocCO.UseVisualStyleBackColor = true;
            this.btnDocCO.Click += new System.EventHandler(this.btnDocCO_Click);
            // 
            // btnDocMG
            // 
            this.btnDocMG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocMG.FlatAppearance.BorderSize = 0;
            this.btnDocMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocMG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocMG.Image = ((System.Drawing.Image)(resources.GetObject("btnDocMG.Image")));
            this.btnDocMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocMG.Location = new System.Drawing.Point(0, 200);
            this.btnDocMG.Name = "btnDocMG";
            this.btnDocMG.Size = new System.Drawing.Size(200, 40);
            this.btnDocMG.TabIndex = 13;
            this.btnDocMG.Text = "MG";
            this.btnDocMG.UseVisualStyleBackColor = true;
            this.btnDocMG.Click += new System.EventHandler(this.btnDocMG_Click);
            // 
            // btnDocRH
            // 
            this.btnDocRH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocRH.FlatAppearance.BorderSize = 0;
            this.btnDocRH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocRH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocRH.Image = ((System.Drawing.Image)(resources.GetObject("btnDocRH.Image")));
            this.btnDocRH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocRH.Location = new System.Drawing.Point(0, 160);
            this.btnDocRH.Name = "btnDocRH";
            this.btnDocRH.Size = new System.Drawing.Size(200, 40);
            this.btnDocRH.TabIndex = 12;
            this.btnDocRH.Text = "RH";
            this.btnDocRH.UseVisualStyleBackColor = true;
            this.btnDocRH.Click += new System.EventHandler(this.btnDocRH_Click);
            // 
            // btnDocAM
            // 
            this.btnDocAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocAM.FlatAppearance.BorderSize = 0;
            this.btnDocAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocAM.Image = ((System.Drawing.Image)(resources.GetObject("btnDocAM.Image")));
            this.btnDocAM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocAM.Location = new System.Drawing.Point(0, 120);
            this.btnDocAM.Name = "btnDocAM";
            this.btnDocAM.Size = new System.Drawing.Size(200, 40);
            this.btnDocAM.TabIndex = 11;
            this.btnDocAM.Text = "AM";
            this.btnDocAM.UseVisualStyleBackColor = true;
            this.btnDocAM.Click += new System.EventHandler(this.btnDocAM_Click);
            // 
            // btnDocDC
            // 
            this.btnDocDC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocDC.FlatAppearance.BorderSize = 0;
            this.btnDocDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocDC.Image = ((System.Drawing.Image)(resources.GetObject("btnDocDC.Image")));
            this.btnDocDC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocDC.Location = new System.Drawing.Point(0, 80);
            this.btnDocDC.Name = "btnDocDC";
            this.btnDocDC.Size = new System.Drawing.Size(200, 40);
            this.btnDocDC.TabIndex = 10;
            this.btnDocDC.Text = "DC";
            this.btnDocDC.UseVisualStyleBackColor = true;
            this.btnDocDC.Click += new System.EventHandler(this.btnDocDC_Click);
            // 
            // btnDocDG
            // 
            this.btnDocDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocDG.FlatAppearance.BorderSize = 0;
            this.btnDocDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocDG.Image = ((System.Drawing.Image)(resources.GetObject("btnDocDG.Image")));
            this.btnDocDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocDG.Location = new System.Drawing.Point(0, 40);
            this.btnDocDG.Name = "btnDocDG";
            this.btnDocDG.Size = new System.Drawing.Size(200, 40);
            this.btnDocDG.TabIndex = 9;
            this.btnDocDG.Text = "DG";
            this.btnDocDG.UseVisualStyleBackColor = true;
            this.btnDocDG.Click += new System.EventHandler(this.btnDocDG_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 20;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(200, 75);
            this.pnlUser.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 20);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(58, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenue";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 50);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 681);
            this.pnlContent.TabIndex = 3;
            // 
            // Form_ModQualite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ModQualite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ModQualite";
            this.Load += new System.EventHandler(this.Form_ModQualite_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlUser;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlButtons;
        public System.Windows.Forms.Button btnDocHSE;
        public System.Windows.Forms.Button btnDocCert;
        public System.Windows.Forms.Button btnDocPR;
        public System.Windows.Forms.Button btnDocCO;
        public System.Windows.Forms.Button btnDocMG;
        public System.Windows.Forms.Button btnDocRH;
        public System.Windows.Forms.Button btnDocAM;
        public System.Windows.Forms.Button btnDocDC;
        public System.Windows.Forms.Button btnDocDG;
        public System.Windows.Forms.Button btnDocForm;
        private System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnModBack;
        public System.Windows.Forms.Button btnDashboard;
    }
}