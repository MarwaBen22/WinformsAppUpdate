
namespace GRHApp.UserControls
{
    partial class UC_Leave
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
            this.txtOtherCauses = new System.Windows.Forms.TextBox();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.dtpLeave = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combCateg = new System.Windows.Forms.ComboBox();
            this.combCause = new System.Windows.Forms.ComboBox();
            this.lblOtherCauses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOtherCauses
            // 
            this.txtOtherCauses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherCauses.Location = new System.Drawing.Point(395, 239);
            this.txtOtherCauses.Name = "txtOtherCauses";
            this.txtOtherCauses.Size = new System.Drawing.Size(228, 24);
            this.txtOtherCauses.TabIndex = 152;
            this.txtOtherCauses.Tag = "tagNam1";
            this.txtOtherCauses.Click += new System.EventHandler(this.txtOtherCauses_Click);
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.Location = new System.Drawing.Point(156, 147);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(108, 18);
            this.lblLeaveDate.TabIndex = 151;
            this.lblLeaveDate.Text = "Date de départ:";
            // 
            // dtpLeave
            // 
            this.dtpLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLeave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeave.Location = new System.Drawing.Point(395, 142);
            this.dtpLeave.Name = "dtpLeave";
            this.dtpLeave.Size = new System.Drawing.Size(145, 24);
            this.dtpLeave.TabIndex = 154;
            this.dtpLeave.Tag = "tagImmo";
            this.dtpLeave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpLeave_MouseDown);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(156, 180);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(233, 18);
            this.lblCategory.TabIndex = 155;
            this.lblCategory.Text = "Categories socio_professionnelle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 156;
            this.label1.Text = "Cause:";
            // 
            // combCateg
            // 
            this.combCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCateg.FormattingEnabled = true;
            this.combCateg.Items.AddRange(new object[] {
            "Cadre dirigeant",
            "Cadre supérieur",
            "Cadre",
            "Maitrise",
            "Exécution"});
            this.combCateg.Location = new System.Drawing.Point(395, 177);
            this.combCateg.Name = "combCateg";
            this.combCateg.Size = new System.Drawing.Size(228, 26);
            this.combCateg.TabIndex = 157;
            this.combCateg.Tag = "tagCateg";
            this.combCateg.Click += new System.EventHandler(this.combLeave_Click);
            this.combCateg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combCateg_MouseClick);
            // 
            // combCause
            // 
            this.combCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCause.FormattingEnabled = true;
            this.combCause.Items.AddRange(new object[] {
            "Sans motif",
            "Motivation pécuniaire",
            "Cas desciplinaire"});
            this.combCause.Location = new System.Drawing.Point(395, 207);
            this.combCause.Name = "combCause";
            this.combCause.Size = new System.Drawing.Size(228, 26);
            this.combCause.TabIndex = 159;
            this.combCause.Tag = "tagCause";
            this.combCause.Click += new System.EventHandler(this.combLeave_Click);
            // 
            // lblOtherCauses
            // 
            this.lblOtherCauses.AutoSize = true;
            this.lblOtherCauses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherCauses.Location = new System.Drawing.Point(156, 242);
            this.lblOtherCauses.Name = "lblOtherCauses";
            this.lblOtherCauses.Size = new System.Drawing.Size(90, 18);
            this.lblOtherCauses.TabIndex = 160;
            this.lblOtherCauses.Text = "Autre cause:";
            // 
            // UC_Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOtherCauses);
            this.Controls.Add(this.combCause);
            this.Controls.Add(this.combCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dtpLeave);
            this.Controls.Add(this.txtOtherCauses);
            this.Controls.Add(this.lblLeaveDate);
            this.Name = "UC_Leave";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_Leave_Load);
            this.Leave += new System.EventHandler(this.UC_Leave_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtOtherCauses;
        private System.Windows.Forms.Label lblLeaveDate;
        public System.Windows.Forms.DateTimePicker dtpLeave;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtherCauses;
        public System.Windows.Forms.ComboBox combCateg;
        public System.Windows.Forms.ComboBox combCause;
    }
}
