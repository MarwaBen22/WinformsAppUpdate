
namespace GRHApp.UserControls
{
    partial class UC_EndContract
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
            this.rbConcluant = new System.Windows.Forms.RadioButton();
            this.lblCConcluat = new System.Windows.Forms.Label();
            this.dtpRenewCon = new System.Windows.Forms.DateTimePicker();
            this.lblRenew = new System.Windows.Forms.Label();
            this.rbNConcluant = new System.Windows.Forms.RadioButton();
            this.lblCNConcluant = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.dtpNotification = new System.Windows.Forms.DateTimePicker();
            this.lblNotification = new System.Windows.Forms.Label();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbConcluant
            // 
            this.rbConcluant.AutoSize = true;
            this.rbConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConcluant.Location = new System.Drawing.Point(243, 117);
            this.rbConcluant.Name = "rbConcluant";
            this.rbConcluant.Size = new System.Drawing.Size(14, 13);
            this.rbConcluant.TabIndex = 152;
            this.rbConcluant.TabStop = true;
            this.rbConcluant.Tag = "tagConConclu";
            this.rbConcluant.UseVisualStyleBackColor = true;
            this.rbConcluant.CheckedChanged += new System.EventHandler(this.rbConcluant_CheckedChanged);
            // 
            // lblCConcluat
            // 
            this.lblCConcluat.AutoSize = true;
            this.lblCConcluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCConcluat.Location = new System.Drawing.Point(100, 114);
            this.lblCConcluat.Name = "lblCConcluat";
            this.lblCConcluat.Size = new System.Drawing.Size(137, 18);
            this.lblCConcluat.TabIndex = 151;
            this.lblCConcluat.Text = "Contract concluant:";
            // 
            // dtpRenewCon
            // 
            this.dtpRenewCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRenewCon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRenewCon.Location = new System.Drawing.Point(258, 156);
            this.dtpRenewCon.Name = "dtpRenewCon";
            this.dtpRenewCon.Size = new System.Drawing.Size(145, 24);
            this.dtpRenewCon.TabIndex = 158;
            this.dtpRenewCon.Tag = "tagRenewDate";
            this.dtpRenewCon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpCon_MouseDown);
            // 
            // lblRenew
            // 
            this.lblRenew.AutoSize = true;
            this.lblRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenew.Location = new System.Drawing.Point(100, 161);
            this.lblRenew.Name = "lblRenew";
            this.lblRenew.Size = new System.Drawing.Size(152, 18);
            this.lblRenew.TabIndex = 157;
            this.lblRenew.Text = "Contract renouvelé le:";
            // 
            // rbNConcluant
            // 
            this.rbNConcluant.AutoSize = true;
            this.rbNConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNConcluant.Location = new System.Drawing.Point(272, 211);
            this.rbNConcluant.Name = "rbNConcluant";
            this.rbNConcluant.Size = new System.Drawing.Size(14, 13);
            this.rbNConcluant.TabIndex = 160;
            this.rbNConcluant.TabStop = true;
            this.rbNConcluant.Tag = "tagConNConclu";
            this.rbNConcluant.UseVisualStyleBackColor = true;
            this.rbNConcluant.CheckedChanged += new System.EventHandler(this.rbNConcluant_CheckedChanged);
            // 
            // lblCNConcluant
            // 
            this.lblCNConcluant.AutoSize = true;
            this.lblCNConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNConcluant.Location = new System.Drawing.Point(100, 208);
            this.lblCNConcluant.Name = "lblCNConcluant";
            this.lblCNConcluant.Size = new System.Drawing.Size(166, 18);
            this.lblCNConcluant.TabIndex = 159;
            this.lblCNConcluant.Text = "Contract non concluant:";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(528, 252);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(150, 24);
            this.txtRef.TabIndex = 191;
            this.txtRef.Tag = "tagRef";
            this.txtRef.Click += new System.EventHandler(this.txtCon_Click);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(470, 255);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(52, 18);
            this.lblRef.TabIndex = 190;
            this.lblRef.Text = "N°Réf:";
            // 
            // dtpNotification
            // 
            this.dtpNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNotification.Location = new System.Drawing.Point(265, 250);
            this.dtpNotification.Name = "dtpNotification";
            this.dtpNotification.Size = new System.Drawing.Size(145, 24);
            this.dtpNotification.TabIndex = 189;
            this.dtpNotification.Tag = "tagNotifDate";
            this.dtpNotification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpCon_MouseDown);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(100, 255);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(159, 18);
            this.lblNotification.TabIndex = 188;
            this.lblNotification.Text = "Lettre de notification le:";
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(440, 115);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(68, 20);
            this.txtContract.TabIndex = 192;
            this.txtContract.Tag = "tagContract";
            this.txtContract.Click += new System.EventHandler(this.txtCon_Click);
            // 
            // UC_EndContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContract);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.dtpNotification);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.rbNConcluant);
            this.Controls.Add(this.lblCNConcluant);
            this.Controls.Add(this.dtpRenewCon);
            this.Controls.Add(this.lblRenew);
            this.Controls.Add(this.rbConcluant);
            this.Controls.Add(this.lblCConcluat);
            this.Name = "UC_EndContract";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_EndContract_Load);
            this.Leave += new System.EventHandler(this.UC_EndContract_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCConcluat;
        public System.Windows.Forms.DateTimePicker dtpRenewCon;
        private System.Windows.Forms.Label lblRenew;
        private System.Windows.Forms.Label lblCNConcluant;
        public System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblRef;
        public System.Windows.Forms.DateTimePicker dtpNotification;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.TextBox txtContract;
        public System.Windows.Forms.RadioButton rbConcluant;
        public System.Windows.Forms.RadioButton rbNConcluant;
    }
}
