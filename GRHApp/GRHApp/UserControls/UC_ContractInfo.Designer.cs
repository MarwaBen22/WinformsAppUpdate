
namespace GRHApp.UserControls
{
    partial class UC_ContractInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.dtpContract = new System.Windows.Forms.DateTimePicker();
            this.lblContractDate = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.dtpEngage = new System.Windows.Forms.DateTimePicker();
            this.lblEngageDate = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.combEtat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPost
            // 
            this.txtPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.Location = new System.Drawing.Point(565, 111);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(150, 24);
            this.txtPost.TabIndex = 147;
            this.txtPost.Tag = "tagPost";
            this.txtPost.Click += new System.EventHandler(this.txtCon_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(420, 114);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(70, 18);
            this.lblPost.TabIndex = 146;
            this.lblPost.Text = "Fonction:";
            // 
            // dtpContract
            // 
            this.dtpContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContract.Location = new System.Drawing.Point(236, 109);
            this.dtpContract.Name = "dtpContract";
            this.dtpContract.Size = new System.Drawing.Size(150, 24);
            this.dtpContract.TabIndex = 145;
            this.dtpContract.Tag = "tagContD";
            this.dtpContract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpContract_MouseDown);
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDate.Location = new System.Drawing.Point(63, 114);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new System.Drawing.Size(63, 18);
            this.lblContractDate.TabIndex = 144;
            this.lblContractDate.Text = "Etabli le:";
            // 
            // txtService
            // 
            this.txtService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.Location = new System.Drawing.Point(236, 150);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(150, 24);
            this.txtService.TabIndex = 149;
            this.txtService.Tag = "tagService";
            this.txtService.Click += new System.EventHandler(this.txtCon_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(63, 156);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(167, 18);
            this.lblService.TabIndex = 148;
            this.lblService.Text = "Direction/Service/Projet:";
            // 
            // dtpEngage
            // 
            this.dtpEngage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEngage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEngage.Location = new System.Drawing.Point(565, 148);
            this.dtpEngage.Name = "dtpEngage";
            this.dtpEngage.Size = new System.Drawing.Size(150, 24);
            this.dtpEngage.TabIndex = 151;
            this.dtpEngage.Tag = "tagStartD";
            this.dtpEngage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpContract_MouseDown);
            // 
            // lblEngageDate
            // 
            this.lblEngageDate.AutoSize = true;
            this.lblEngageDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngageDate.Location = new System.Drawing.Point(420, 153);
            this.lblEngageDate.Name = "lblEngageDate";
            this.lblEngageDate.Size = new System.Drawing.Size(139, 18);
            this.lblEngageDate.TabIndex = 150;
            this.lblEngageDate.Text = "Date d\'engagement:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(63, 204);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 18);
            this.lblState.TabIndex = 152;
            this.lblState.Text = "Etat:";
            // 
            // combEtat
            // 
            this.combEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combEtat.FormattingEnabled = true;
            this.combEtat.Items.AddRange(new object[] {
            "Cadre Dirigeant",
            "Cadre Supérieur",
            "Cadre",
            "Maitrise",
            "Exécution"});
            this.combEtat.Location = new System.Drawing.Point(236, 201);
            this.combEtat.Name = "combEtat";
            this.combEtat.Size = new System.Drawing.Size(254, 26);
            this.combEtat.TabIndex = 154;
            this.combEtat.Click += new System.EventHandler(this.combEtat_Click);
            // 
            // UC_ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combEtat);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.dtpEngage);
            this.Controls.Add(this.lblEngageDate);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.dtpContract);
            this.Controls.Add(this.lblContractDate);
            this.Name = "UC_ContractInfo";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_ContractInfo_Load);
            this.Leave += new System.EventHandler(this.UC_ContractInfo_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label lblPost;
        public System.Windows.Forms.DateTimePicker dtpContract;
        private System.Windows.Forms.Label lblContractDate;
        public System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblService;
        public System.Windows.Forms.DateTimePicker dtpEngage;
        private System.Windows.Forms.Label lblEngageDate;
        private System.Windows.Forms.Label lblState;
        public System.Windows.Forms.ComboBox combEtat;
    }
}
