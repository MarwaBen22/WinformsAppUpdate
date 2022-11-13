
namespace GRHApp.UserControls
{
    partial class UC_Military
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
            this.lblSursiTo = new System.Windows.Forms.Label();
            this.dtpImmo = new System.Windows.Forms.DateTimePicker();
            this.lblImmoDate = new System.Windows.Forms.Label();
            this.lblSursi = new System.Windows.Forms.Label();
            this.lblEngage = new System.Windows.Forms.Label();
            this.rbEngageY = new System.Windows.Forms.RadioButton();
            this.rbEngageN = new System.Windows.Forms.RadioButton();
            this.dtpSursiTo = new System.Windows.Forms.DateTimePicker();
            this.dtpSursiFrom = new System.Windows.Forms.DateTimePicker();
            this.rbAbilityN = new System.Windows.Forms.RadioButton();
            this.rbAbilityY = new System.Windows.Forms.RadioButton();
            this.lblAbility = new System.Windows.Forms.Label();
            this.pnlYN0 = new System.Windows.Forms.Panel();
            this.pnlYN1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlYN0.SuspendLayout();
            this.pnlYN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSursiTo
            // 
            this.lblSursiTo.AutoSize = true;
            this.lblSursiTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSursiTo.Location = new System.Drawing.Point(519, 173);
            this.lblSursiTo.Name = "lblSursiTo";
            this.lblSursiTo.Size = new System.Drawing.Size(29, 18);
            this.lblSursiTo.TabIndex = 90;
            this.lblSursiTo.Text = "Au:";
            // 
            // dtpImmo
            // 
            this.dtpImmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImmo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImmo.Location = new System.Drawing.Point(239, 140);
            this.dtpImmo.Name = "dtpImmo";
            this.dtpImmo.Size = new System.Drawing.Size(145, 24);
            this.dtpImmo.TabIndex = 88;
            this.dtpImmo.Tag = "tagImmo";
            this.dtpImmo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpM_MouseDown);
            // 
            // lblImmoDate
            // 
            this.lblImmoDate.AutoSize = true;
            this.lblImmoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmoDate.Location = new System.Drawing.Point(80, 145);
            this.lblImmoDate.Name = "lblImmoDate";
            this.lblImmoDate.Size = new System.Drawing.Size(153, 18);
            this.lblImmoDate.TabIndex = 87;
            this.lblImmoDate.Text = "Date d\'immobilisation:";
            // 
            // lblSursi
            // 
            this.lblSursi.AutoSize = true;
            this.lblSursi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSursi.Location = new System.Drawing.Point(80, 173);
            this.lblSursi.Name = "lblSursi";
            this.lblSursi.Size = new System.Drawing.Size(94, 18);
            this.lblSursi.TabIndex = 86;
            this.lblSursi.Text = "Sursitaire du:";
            // 
            // lblEngage
            // 
            this.lblEngage.AutoSize = true;
            this.lblEngage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngage.Location = new System.Drawing.Point(80, 114);
            this.lblEngage.Name = "lblEngage";
            this.lblEngage.Size = new System.Drawing.Size(63, 18);
            this.lblEngage.TabIndex = 83;
            this.lblEngage.Text = "Dégagé:";
            // 
            // rbEngageY
            // 
            this.rbEngageY.AutoSize = true;
            this.rbEngageY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEngageY.Location = new System.Drawing.Point(3, 3);
            this.rbEngageY.Name = "rbEngageY";
            this.rbEngageY.Size = new System.Drawing.Size(52, 22);
            this.rbEngageY.TabIndex = 91;
            this.rbEngageY.Tag = "tagEngY";
            this.rbEngageY.Text = "OUI";
            this.rbEngageY.UseVisualStyleBackColor = true;
            this.rbEngageY.CheckedChanged += new System.EventHandler(this.rbEngageY_CheckedChanged);
            this.rbEngageY.Click += new System.EventHandler(this.rb_Click);
            this.rbEngageY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbEngageY_MouseClick);
            // 
            // rbEngageN
            // 
            this.rbEngageN.AutoSize = true;
            this.rbEngageN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEngageN.Location = new System.Drawing.Point(88, 3);
            this.rbEngageN.Name = "rbEngageN";
            this.rbEngageN.Size = new System.Drawing.Size(60, 22);
            this.rbEngageN.TabIndex = 92;
            this.rbEngageN.Tag = "tagEngN";
            this.rbEngageN.Text = "NON";
            this.rbEngageN.UseVisualStyleBackColor = true;
            this.rbEngageN.CheckedChanged += new System.EventHandler(this.rbEngageN_CheckedChanged);
            this.rbEngageN.Click += new System.EventHandler(this.rb_Click);
            // 
            // dtpSursiTo
            // 
            this.dtpSursiTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSursiTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSursiTo.Location = new System.Drawing.Point(554, 170);
            this.dtpSursiTo.Name = "dtpSursiTo";
            this.dtpSursiTo.Size = new System.Drawing.Size(145, 24);
            this.dtpSursiTo.TabIndex = 93;
            this.dtpSursiTo.Tag = "tagSursiT";
            this.dtpSursiTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpM_MouseDown);
            // 
            // dtpSursiFrom
            // 
            this.dtpSursiFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSursiFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSursiFrom.Location = new System.Drawing.Point(239, 170);
            this.dtpSursiFrom.Name = "dtpSursiFrom";
            this.dtpSursiFrom.Size = new System.Drawing.Size(145, 24);
            this.dtpSursiFrom.TabIndex = 94;
            this.dtpSursiFrom.Tag = "tagSursiF";
            this.dtpSursiFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpM_MouseDown);
            // 
            // rbAbilityN
            // 
            this.rbAbilityN.AutoSize = true;
            this.rbAbilityN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbilityN.Location = new System.Drawing.Point(88, 3);
            this.rbAbilityN.Name = "rbAbilityN";
            this.rbAbilityN.Size = new System.Drawing.Size(60, 22);
            this.rbAbilityN.TabIndex = 97;
            this.rbAbilityN.TabStop = true;
            this.rbAbilityN.Tag = "tagAptN";
            this.rbAbilityN.Text = "NON";
            this.rbAbilityN.UseVisualStyleBackColor = true;
            this.rbAbilityN.CheckedChanged += new System.EventHandler(this.rbAbilityN_CheckedChanged);
            this.rbAbilityN.Click += new System.EventHandler(this.rb_Click);
            // 
            // rbAbilityY
            // 
            this.rbAbilityY.AutoSize = true;
            this.rbAbilityY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbilityY.Location = new System.Drawing.Point(3, 3);
            this.rbAbilityY.Name = "rbAbilityY";
            this.rbAbilityY.Size = new System.Drawing.Size(52, 22);
            this.rbAbilityY.TabIndex = 96;
            this.rbAbilityY.TabStop = true;
            this.rbAbilityY.Tag = "tagAptY";
            this.rbAbilityY.Text = "OUI";
            this.rbAbilityY.UseVisualStyleBackColor = true;
            this.rbAbilityY.CheckedChanged += new System.EventHandler(this.rbAbilityY_CheckedChanged);
            this.rbAbilityY.Click += new System.EventHandler(this.rb_Click);
            // 
            // lblAbility
            // 
            this.lblAbility.AutoSize = true;
            this.lblAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbility.Location = new System.Drawing.Point(80, 202);
            this.lblAbility.Name = "lblAbility";
            this.lblAbility.Size = new System.Drawing.Size(156, 18);
            this.lblAbility.TabIndex = 95;
            this.lblAbility.Text = "Apte non incorporable:";
            // 
            // pnlYN0
            // 
            this.pnlYN0.Controls.Add(this.rbEngageY);
            this.pnlYN0.Controls.Add(this.rbEngageN);
            this.pnlYN0.Location = new System.Drawing.Point(238, 106);
            this.pnlYN0.Name = "pnlYN0";
            this.pnlYN0.Size = new System.Drawing.Size(153, 31);
            this.pnlYN0.TabIndex = 98;
            this.pnlYN0.Click += new System.EventHandler(this.pnlYN0_Click);
            // 
            // pnlYN1
            // 
            this.pnlYN1.Controls.Add(this.rbAbilityY);
            this.pnlYN1.Controls.Add(this.rbAbilityN);
            this.pnlYN1.Location = new System.Drawing.Point(239, 197);
            this.pnlYN1.Name = "pnlYN1";
            this.pnlYN1.Size = new System.Drawing.Size(153, 31);
            this.pnlYN1.TabIndex = 99;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 142;
            this.textBox1.Tag = "tagText2";
            this.textBox1.Visible = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(398, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 143;
            this.textBox2.Tag = "tagText";
            this.textBox2.Visible = false;
            this.textBox2.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // UC_Military
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlYN1);
            this.Controls.Add(this.pnlYN0);
            this.Controls.Add(this.lblAbility);
            this.Controls.Add(this.dtpSursiFrom);
            this.Controls.Add(this.dtpSursiTo);
            this.Controls.Add(this.lblSursiTo);
            this.Controls.Add(this.dtpImmo);
            this.Controls.Add(this.lblImmoDate);
            this.Controls.Add(this.lblSursi);
            this.Controls.Add(this.lblEngage);
            this.Name = "UC_Military";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_Military_Load);
            this.Leave += new System.EventHandler(this.UC_Military_Leave);
            this.pnlYN0.ResumeLayout(false);
            this.pnlYN0.PerformLayout();
            this.pnlYN1.ResumeLayout(false);
            this.pnlYN1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSursiTo;
        public System.Windows.Forms.DateTimePicker dtpImmo;
        private System.Windows.Forms.Label lblImmoDate;
        private System.Windows.Forms.Label lblSursi;
        private System.Windows.Forms.Label lblEngage;
        public System.Windows.Forms.DateTimePicker dtpSursiTo;
        public System.Windows.Forms.DateTimePicker dtpSursiFrom;
        private System.Windows.Forms.Label lblAbility;
        public System.Windows.Forms.Panel pnlYN0;
        public System.Windows.Forms.Panel pnlYN1;
        public System.Windows.Forms.RadioButton rbEngageY;
        public System.Windows.Forms.RadioButton rbEngageN;
        public System.Windows.Forms.RadioButton rbAbilityN;
        public System.Windows.Forms.RadioButton rbAbilityY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
