
namespace GRHApp.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.pnlDocuments = new System.Windows.Forms.Panel();
            this.btnHoliday = new System.Windows.Forms.Button();
            this.btnWorkCert = new System.Windows.Forms.Button();
            this.btnWorkAttes = new System.Windows.Forms.Button();
            this.btnRecruitingF = new System.Windows.Forms.Button();
            this.pnlDemRec = new System.Windows.Forms.Panel();
            this.btnNotifDRec = new System.Windows.Forms.Button();
            this.btnAddDRec = new System.Windows.Forms.Button();
            this.btnRecruitDem = new System.Windows.Forms.Button();
            this.btnDocument = new System.Windows.Forms.Button();
            this.pnlDashList = new System.Windows.Forms.Panel();
            this.btnDashCong = new System.Windows.Forms.Button();
            this.btnDashCert = new System.Windows.Forms.Button();
            this.btnDashAttes = new System.Windows.Forms.Button();
            this.btnDashRenseign = new System.Windows.Forms.Button();
            this.btnDashDR = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnModBack = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlDocuments.SuspendLayout();
            this.pnlDemRec.SuspendLayout();
            this.pnlDashList.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
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
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Système de gestion \r\ndes resources humaines";
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
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoScroll = true;
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnManageAccount);
            this.pnlButtons.Controls.Add(this.btnUsers);
            this.pnlButtons.Controls.Add(this.btnAlerts);
            this.pnlButtons.Controls.Add(this.btnJournal);
            this.pnlButtons.Controls.Add(this.pnlDocuments);
            this.pnlButtons.Controls.Add(this.btnDocument);
            this.pnlButtons.Controls.Add(this.pnlDashList);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 75);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(200, 606);
            this.pnlButtons.TabIndex = 1;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 751);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(183, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnManageAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnManageAccount.Image")));
            this.btnManageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 711);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(183, 40);
            this.btnManageAccount.TabIndex = 11;
            this.btnManageAccount.Text = "Gérer mon compte";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 671);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(183, 40);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Utilisateurs";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAlerts
            // 
            this.btnAlerts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnAlerts.Image = ((System.Drawing.Image)(resources.GetObject("btnAlerts.Image")));
            this.btnAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerts.Location = new System.Drawing.Point(0, 631);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Size = new System.Drawing.Size(183, 40);
            this.btnAlerts.TabIndex = 12;
            this.btnAlerts.Text = "Les alertes";
            this.btnAlerts.UseVisualStyleBackColor = true;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJournal.FlatAppearance.BorderSize = 0;
            this.btnJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJournal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnJournal.Image = ((System.Drawing.Image)(resources.GetObject("btnJournal.Image")));
            this.btnJournal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJournal.Location = new System.Drawing.Point(0, 591);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(183, 40);
            this.btnJournal.TabIndex = 6;
            this.btnJournal.Text = "  Journal d\'activité";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // pnlDocuments
            // 
            this.pnlDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.pnlDocuments.Controls.Add(this.btnHoliday);
            this.pnlDocuments.Controls.Add(this.btnWorkCert);
            this.pnlDocuments.Controls.Add(this.btnWorkAttes);
            this.pnlDocuments.Controls.Add(this.btnRecruitingF);
            this.pnlDocuments.Controls.Add(this.pnlDemRec);
            this.pnlDocuments.Controls.Add(this.btnRecruitDem);
            this.pnlDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocuments.Location = new System.Drawing.Point(0, 290);
            this.pnlDocuments.Name = "pnlDocuments";
            this.pnlDocuments.Size = new System.Drawing.Size(183, 301);
            this.pnlDocuments.TabIndex = 9;
            this.pnlDocuments.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDocuments_Paint);
            // 
            // btnHoliday
            // 
            this.btnHoliday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoliday.FlatAppearance.BorderSize = 0;
            this.btnHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoliday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnHoliday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.Location = new System.Drawing.Point(0, 257);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Size = new System.Drawing.Size(183, 40);
            this.btnHoliday.TabIndex = 8;
            this.btnHoliday.Text = "Titre de congé";
            this.btnHoliday.UseVisualStyleBackColor = true;
            this.btnHoliday.Click += new System.EventHandler(this.btnHoliday_Click);
            // 
            // btnWorkCert
            // 
            this.btnWorkCert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkCert.FlatAppearance.BorderSize = 0;
            this.btnWorkCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkCert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnWorkCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkCert.Location = new System.Drawing.Point(0, 217);
            this.btnWorkCert.Name = "btnWorkCert";
            this.btnWorkCert.Size = new System.Drawing.Size(183, 40);
            this.btnWorkCert.TabIndex = 7;
            this.btnWorkCert.Text = "Certificat de travail";
            this.btnWorkCert.UseVisualStyleBackColor = true;
            this.btnWorkCert.Click += new System.EventHandler(this.btnWorkCert_Click);
            // 
            // btnWorkAttes
            // 
            this.btnWorkAttes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkAttes.FlatAppearance.BorderSize = 0;
            this.btnWorkAttes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkAttes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkAttes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnWorkAttes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkAttes.Location = new System.Drawing.Point(0, 177);
            this.btnWorkAttes.Name = "btnWorkAttes";
            this.btnWorkAttes.Size = new System.Drawing.Size(183, 40);
            this.btnWorkAttes.TabIndex = 6;
            this.btnWorkAttes.Text = "Attestation de travail";
            this.btnWorkAttes.UseVisualStyleBackColor = true;
            this.btnWorkAttes.Click += new System.EventHandler(this.btnWorkAttes_Click);
            // 
            // btnRecruitingF
            // 
            this.btnRecruitingF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruitingF.FlatAppearance.BorderSize = 0;
            this.btnRecruitingF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruitingF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecruitingF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnRecruitingF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitingF.Location = new System.Drawing.Point(0, 127);
            this.btnRecruitingF.Name = "btnRecruitingF";
            this.btnRecruitingF.Size = new System.Drawing.Size(183, 50);
            this.btnRecruitingF.TabIndex = 5;
            this.btnRecruitingF.Text = "Fiche de renseignements \r\n& carrière";
            this.btnRecruitingF.UseVisualStyleBackColor = true;
            this.btnRecruitingF.Click += new System.EventHandler(this.btnRecruitingF_Click);
            // 
            // pnlDemRec
            // 
            this.pnlDemRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(121)))), ((int)(((byte)(115)))));
            this.pnlDemRec.Controls.Add(this.btnNotifDRec);
            this.pnlDemRec.Controls.Add(this.btnAddDRec);
            this.pnlDemRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDemRec.Location = new System.Drawing.Point(0, 40);
            this.pnlDemRec.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDemRec.Name = "pnlDemRec";
            this.pnlDemRec.Size = new System.Drawing.Size(183, 87);
            this.pnlDemRec.TabIndex = 9;
            // 
            // btnNotifDRec
            // 
            this.btnNotifDRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifDRec.FlatAppearance.BorderSize = 0;
            this.btnNotifDRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifDRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifDRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnNotifDRec.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifDRec.Image")));
            this.btnNotifDRec.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNotifDRec.Location = new System.Drawing.Point(0, 40);
            this.btnNotifDRec.Name = "btnNotifDRec";
            this.btnNotifDRec.Size = new System.Drawing.Size(183, 40);
            this.btnNotifDRec.TabIndex = 11;
            this.btnNotifDRec.Text = "Notifications";
            this.btnNotifDRec.UseVisualStyleBackColor = true;
            this.btnNotifDRec.Click += new System.EventHandler(this.btnNotifDRec_Click);
            // 
            // btnAddDRec
            // 
            this.btnAddDRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDRec.FlatAppearance.BorderSize = 0;
            this.btnAddDRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnAddDRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDRec.Location = new System.Drawing.Point(0, 0);
            this.btnAddDRec.Name = "btnAddDRec";
            this.btnAddDRec.Size = new System.Drawing.Size(183, 40);
            this.btnAddDRec.TabIndex = 10;
            this.btnAddDRec.Text = "Ajouter ";
            this.btnAddDRec.UseVisualStyleBackColor = true;
            this.btnAddDRec.Click += new System.EventHandler(this.btnAddDRec_Click);
            // 
            // btnRecruitDem
            // 
            this.btnRecruitDem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruitDem.FlatAppearance.BorderSize = 0;
            this.btnRecruitDem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruitDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecruitDem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnRecruitDem.Image = ((System.Drawing.Image)(resources.GetObject("btnRecruitDem.Image")));
            this.btnRecruitDem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRecruitDem.Location = new System.Drawing.Point(0, 0);
            this.btnRecruitDem.Name = "btnRecruitDem";
            this.btnRecruitDem.Size = new System.Drawing.Size(183, 40);
            this.btnRecruitDem.TabIndex = 4;
            this.btnRecruitDem.Text = "Fiche de recrutement";
            this.btnRecruitDem.UseVisualStyleBackColor = true;
            this.btnRecruitDem.Click += new System.EventHandler(this.btnRecruitDem_Click);
            // 
            // btnDocument
            // 
            this.btnDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocument.FlatAppearance.BorderSize = 0;
            this.btnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnDocument.Image")));
            this.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocument.Location = new System.Drawing.Point(0, 250);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(183, 40);
            this.btnDocument.TabIndex = 8;
            this.btnDocument.Text = "Gestion de document";
            this.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocument.UseVisualStyleBackColor = true;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // pnlDashList
            // 
            this.pnlDashList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.pnlDashList.Controls.Add(this.btnDashCong);
            this.pnlDashList.Controls.Add(this.btnDashCert);
            this.pnlDashList.Controls.Add(this.btnDashAttes);
            this.pnlDashList.Controls.Add(this.btnDashRenseign);
            this.pnlDashList.Controls.Add(this.btnDashDR);
            this.pnlDashList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashList.Location = new System.Drawing.Point(0, 40);
            this.pnlDashList.Name = "pnlDashList";
            this.pnlDashList.Size = new System.Drawing.Size(183, 210);
            this.pnlDashList.TabIndex = 0;
            // 
            // btnDashCong
            // 
            this.btnDashCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashCong.FlatAppearance.BorderSize = 0;
            this.btnDashCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashCong.Location = new System.Drawing.Point(0, 166);
            this.btnDashCong.Name = "btnDashCong";
            this.btnDashCong.Size = new System.Drawing.Size(183, 40);
            this.btnDashCong.TabIndex = 11;
            this.btnDashCong.Text = "Titre de congé";
            this.btnDashCong.UseVisualStyleBackColor = true;
            this.btnDashCong.Click += new System.EventHandler(this.btnDashCong_Click);
            // 
            // btnDashCert
            // 
            this.btnDashCert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashCert.FlatAppearance.BorderSize = 0;
            this.btnDashCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashCert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashCert.Location = new System.Drawing.Point(0, 126);
            this.btnDashCert.Name = "btnDashCert";
            this.btnDashCert.Size = new System.Drawing.Size(183, 40);
            this.btnDashCert.TabIndex = 10;
            this.btnDashCert.Text = "Certificat de travail";
            this.btnDashCert.UseVisualStyleBackColor = true;
            this.btnDashCert.Click += new System.EventHandler(this.btnDashCert_Click);
            // 
            // btnDashAttes
            // 
            this.btnDashAttes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashAttes.FlatAppearance.BorderSize = 0;
            this.btnDashAttes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashAttes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashAttes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashAttes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashAttes.Location = new System.Drawing.Point(0, 86);
            this.btnDashAttes.Name = "btnDashAttes";
            this.btnDashAttes.Size = new System.Drawing.Size(183, 40);
            this.btnDashAttes.TabIndex = 9;
            this.btnDashAttes.Text = "Attestation de travail";
            this.btnDashAttes.UseVisualStyleBackColor = true;
            this.btnDashAttes.Click += new System.EventHandler(this.btnDashAttes_Click);
            // 
            // btnDashRenseign
            // 
            this.btnDashRenseign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashRenseign.FlatAppearance.BorderSize = 0;
            this.btnDashRenseign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashRenseign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashRenseign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashRenseign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashRenseign.Location = new System.Drawing.Point(0, 40);
            this.btnDashRenseign.Name = "btnDashRenseign";
            this.btnDashRenseign.Size = new System.Drawing.Size(183, 46);
            this.btnDashRenseign.TabIndex = 12;
            this.btnDashRenseign.Text = "Fiche de renseignements";
            this.btnDashRenseign.UseVisualStyleBackColor = true;
            this.btnDashRenseign.Click += new System.EventHandler(this.btnDashRenseign_Click);
            // 
            // btnDashDR
            // 
            this.btnDashDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashDR.FlatAppearance.BorderSize = 0;
            this.btnDashDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashDR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnDashDR.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDashDR.Location = new System.Drawing.Point(0, 0);
            this.btnDashDR.Name = "btnDashDR";
            this.btnDashDR.Size = new System.Drawing.Size(183, 40);
            this.btnDashDR.TabIndex = 5;
            this.btnDashDR.Text = "Fiche de recrutement";
            this.btnDashDR.UseVisualStyleBackColor = true;
            this.btnDashDR.Click += new System.EventHandler(this.btnDashDR_Click);
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
            this.btnDashboard.Size = new System.Drawing.Size(183, 40);
            this.btnDashboard.TabIndex = 0;
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
            this.pnlUser.TabIndex = 0;
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
            this.pnlContent.TabIndex = 0;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            this.btnModBack.TabIndex = 7;
            this.btnModBack.UseVisualStyleBackColor = true;
            this.btnModBack.Click += new System.EventHandler(this.btnModBack_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlDocuments.ResumeLayout(false);
            this.pnlDemRec.ResumeLayout(false);
            this.pnlDashList.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlUser;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDocuments;
        private System.Windows.Forms.Button btnWorkCert;
        private System.Windows.Forms.Button btnWorkAttes;
        private System.Windows.Forms.Button btnRecruitingF;
        private System.Windows.Forms.Button btnHoliday;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Button btnJournal;
        public System.Windows.Forms.Button btnDocument;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnManageAccount;
        public System.Windows.Forms.Button btnRecruitDem;
        private System.Windows.Forms.Panel pnlDemRec;
        private System.Windows.Forms.Button btnAddDRec;
        public System.Windows.Forms.Button btnNotifDRec;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlDashList;
        private System.Windows.Forms.Button btnDashCong;
        private System.Windows.Forms.Button btnDashCert;
        private System.Windows.Forms.Button btnDashAttes;
        public System.Windows.Forms.Button btnDashDR;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDashRenseign;
        private System.Windows.Forms.Button btnModBack;
    }
}