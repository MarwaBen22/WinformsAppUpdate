
namespace GRHApp.UserControls
{
    partial class UC_TrialPeriod
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
            this.lblPConcluat = new System.Windows.Forms.Label();
            this.rbConcluant = new System.Windows.Forms.RadioButton();
            this.rbPAdd = new System.Windows.Forms.RadioButton();
            this.lblPAdd = new System.Windows.Forms.Label();
            this.rbPNConcluant = new System.Windows.Forms.RadioButton();
            this.lblPNConcluant = new System.Windows.Forms.Label();
            this.dtpNotification = new System.Windows.Forms.DateTimePicker();
            this.lblNotification = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtTri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPConcluat
            // 
            this.lblPConcluat.AutoSize = true;
            this.lblPConcluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPConcluat.Location = new System.Drawing.Point(94, 114);
            this.lblPConcluat.Name = "lblPConcluat";
            this.lblPConcluat.Size = new System.Drawing.Size(181, 18);
            this.lblPConcluat.TabIndex = 149;
            this.lblPConcluat.Text = "Période d\'essai concluant:";
            // 
            // rbConcluant
            // 
            this.rbConcluant.AutoSize = true;
            this.rbConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConcluant.Location = new System.Drawing.Point(281, 117);
            this.rbConcluant.Name = "rbConcluant";
            this.rbConcluant.Size = new System.Drawing.Size(14, 13);
            this.rbConcluant.TabIndex = 150;
            this.rbConcluant.TabStop = true;
            this.rbConcluant.Tag = "tagTriCon";
            this.rbConcluant.UseVisualStyleBackColor = true;
            this.rbConcluant.CheckedChanged += new System.EventHandler(this.rbConcluant_CheckedChanged);
            this.rbConcluant.Click += new System.EventHandler(this.rbP_Click);
            // 
            // rbPAdd
            // 
            this.rbPAdd.AutoSize = true;
            this.rbPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPAdd.Location = new System.Drawing.Point(658, 117);
            this.rbPAdd.Name = "rbPAdd";
            this.rbPAdd.Size = new System.Drawing.Size(14, 13);
            this.rbPAdd.TabIndex = 152;
            this.rbPAdd.TabStop = true;
            this.rbPAdd.Tag = "tagTriExtend";
            this.rbPAdd.UseVisualStyleBackColor = true;
            this.rbPAdd.CheckedChanged += new System.EventHandler(this.rbPAdd_CheckedChanged);
            this.rbPAdd.Click += new System.EventHandler(this.rbP_Click);
            // 
            // lblPAdd
            // 
            this.lblPAdd.AutoSize = true;
            this.lblPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAdd.Location = new System.Drawing.Point(460, 114);
            this.lblPAdd.Name = "lblPAdd";
            this.lblPAdd.Size = new System.Drawing.Size(192, 18);
            this.lblPAdd.TabIndex = 151;
            this.lblPAdd.Text = "Période d\'essai à prolonger:";
            // 
            // rbPNConcluant
            // 
            this.rbPNConcluant.AutoSize = true;
            this.rbPNConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPNConcluant.Location = new System.Drawing.Point(246, 158);
            this.rbPNConcluant.Name = "rbPNConcluant";
            this.rbPNConcluant.Size = new System.Drawing.Size(14, 13);
            this.rbPNConcluant.TabIndex = 154;
            this.rbPNConcluant.TabStop = true;
            this.rbPNConcluant.Tag = "tagTriNCon";
            this.rbPNConcluant.UseVisualStyleBackColor = true;
            this.rbPNConcluant.CheckedChanged += new System.EventHandler(this.rbPNConcluant_CheckedChanged);
            this.rbPNConcluant.Click += new System.EventHandler(this.rbP_Click);
            // 
            // lblPNConcluant
            // 
            this.lblPNConcluant.AutoSize = true;
            this.lblPNConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNConcluant.Location = new System.Drawing.Point(94, 155);
            this.lblPNConcluant.Name = "lblPNConcluant";
            this.lblPNConcluant.Size = new System.Drawing.Size(146, 18);
            this.lblPNConcluant.TabIndex = 153;
            this.lblPNConcluant.Text = "Essai non concluant:";
            // 
            // dtpNotification
            // 
            this.dtpNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNotification.Location = new System.Drawing.Point(259, 191);
            this.dtpNotification.Name = "dtpNotification";
            this.dtpNotification.Size = new System.Drawing.Size(145, 24);
            this.dtpNotification.TabIndex = 156;
            this.dtpNotification.Tag = "tagNotif";
            this.dtpNotification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpNotification_MouseDown);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(94, 196);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(159, 18);
            this.lblNotification.TabIndex = 155;
            this.lblNotification.Text = "Lettre de notification le:";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(522, 193);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(150, 24);
            this.txtRef.TabIndex = 187;
            this.txtRef.Tag = "tagRef";
            this.txtRef.Click += new System.EventHandler(this.txtT_Click);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(460, 196);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(35, 18);
            this.lblRef.TabIndex = 186;
            this.lblRef.Text = "Réf:";
            // 
            // txtTri
            // 
            this.txtTri.Location = new System.Drawing.Point(698, 115);
            this.txtTri.Name = "txtTri";
            this.txtTri.Size = new System.Drawing.Size(60, 20);
            this.txtTri.TabIndex = 188;
            this.txtTri.Tag = "tagTri";
            this.txtTri.Visible = false;
            this.txtTri.Click += new System.EventHandler(this.txtT_Click);
            // 
            // UC_TrialPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTri);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.dtpNotification);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.rbPNConcluant);
            this.Controls.Add(this.lblPNConcluant);
            this.Controls.Add(this.rbPAdd);
            this.Controls.Add(this.lblPAdd);
            this.Controls.Add(this.rbConcluant);
            this.Controls.Add(this.lblPConcluat);
            this.Name = "UC_TrialPeriod";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_TrialPeriod_Load);
            this.Leave += new System.EventHandler(this.UC_TrialPeriod_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPConcluat;
        private System.Windows.Forms.Label lblPAdd;
        private System.Windows.Forms.Label lblPNConcluant;
        public System.Windows.Forms.DateTimePicker dtpNotification;
        private System.Windows.Forms.Label lblNotification;
        public System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtTri;
        public System.Windows.Forms.RadioButton rbConcluant;
        public System.Windows.Forms.RadioButton rbPAdd;
        public System.Windows.Forms.RadioButton rbPNConcluant;
    }
}
