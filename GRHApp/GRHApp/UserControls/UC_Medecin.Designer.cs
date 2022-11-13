
namespace GRHApp.UserControls
{
    partial class UC_Medecin
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
            this.lblTitleMed = new System.Windows.Forms.Label();
            this.pnlMed = new System.Windows.Forms.Panel();
            this.rbMedNC = new System.Windows.Forms.RadioButton();
            this.rbMedC = new System.Windows.Forms.RadioButton();
            this.lblMedConclut = new System.Windows.Forms.Label();
            this.lblMedNonConclut = new System.Windows.Forms.Label();
            this.lblProNoConlu = new System.Windows.Forms.Label();
            this.lblProConlu = new System.Windows.Forms.Label();
            this.pnlProf = new System.Windows.Forms.Panel();
            this.rbProNC = new System.Windows.Forms.RadioButton();
            this.rbProC = new System.Windows.Forms.RadioButton();
            this.lblTestProf = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.pnlMed.SuspendLayout();
            this.pnlProf.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleMed
            // 
            this.lblTitleMed.AutoSize = true;
            this.lblTitleMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMed.Location = new System.Drawing.Point(127, 114);
            this.lblTitleMed.Name = "lblTitleMed";
            this.lblTitleMed.Size = new System.Drawing.Size(153, 18);
            this.lblTitleMed.TabIndex = 147;
            this.lblTitleMed.Text = "Médecine de travail";
            // 
            // pnlMed
            // 
            this.pnlMed.Controls.Add(this.rbMedNC);
            this.pnlMed.Controls.Add(this.rbMedC);
            this.pnlMed.Location = new System.Drawing.Point(281, 153);
            this.pnlMed.Name = "pnlMed";
            this.pnlMed.Size = new System.Drawing.Size(20, 64);
            this.pnlMed.TabIndex = 151;
            // 
            // rbMedNC
            // 
            this.rbMedNC.AutoSize = true;
            this.rbMedNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedNC.Location = new System.Drawing.Point(3, 40);
            this.rbMedNC.Name = "rbMedNC";
            this.rbMedNC.Size = new System.Drawing.Size(14, 13);
            this.rbMedNC.TabIndex = 130;
            this.rbMedNC.TabStop = true;
            this.rbMedNC.Tag = "tagMdNC";
            this.rbMedNC.UseVisualStyleBackColor = true;
            this.rbMedNC.CheckedChanged += new System.EventHandler(this.rbMedNC_CheckedChanged);
            this.rbMedNC.Click += new System.EventHandler(this.rbTest_Click);
            // 
            // rbMedC
            // 
            this.rbMedC.AutoSize = true;
            this.rbMedC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedC.Location = new System.Drawing.Point(3, 3);
            this.rbMedC.Name = "rbMedC";
            this.rbMedC.Size = new System.Drawing.Size(14, 13);
            this.rbMedC.TabIndex = 128;
            this.rbMedC.TabStop = true;
            this.rbMedC.Tag = "tagMdC";
            this.rbMedC.UseVisualStyleBackColor = true;
            this.rbMedC.CheckedChanged += new System.EventHandler(this.rbMedC_CheckedChanged);
            this.rbMedC.Click += new System.EventHandler(this.rbTest_Click);
            // 
            // lblMedConclut
            // 
            this.lblMedConclut.AutoSize = true;
            this.lblMedConclut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedConclut.Location = new System.Drawing.Point(100, 153);
            this.lblMedConclut.Name = "lblMedConclut";
            this.lblMedConclut.Size = new System.Drawing.Size(120, 18);
            this.lblMedConclut.TabIndex = 152;
            this.lblMedConclut.Text = "Test Conculuant:";
            // 
            // lblMedNonConclut
            // 
            this.lblMedNonConclut.AutoSize = true;
            this.lblMedNonConclut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedNonConclut.Location = new System.Drawing.Point(100, 190);
            this.lblMedNonConclut.Name = "lblMedNonConclut";
            this.lblMedNonConclut.Size = new System.Drawing.Size(138, 18);
            this.lblMedNonConclut.TabIndex = 153;
            this.lblMedNonConclut.Text = "Test non concluant:";
            // 
            // lblProNoConlu
            // 
            this.lblProNoConlu.AutoSize = true;
            this.lblProNoConlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProNoConlu.Location = new System.Drawing.Point(478, 190);
            this.lblProNoConlu.Name = "lblProNoConlu";
            this.lblProNoConlu.Size = new System.Drawing.Size(138, 18);
            this.lblProNoConlu.TabIndex = 157;
            this.lblProNoConlu.Text = "Test non concluant:";
            // 
            // lblProConlu
            // 
            this.lblProConlu.AutoSize = true;
            this.lblProConlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProConlu.Location = new System.Drawing.Point(478, 153);
            this.lblProConlu.Name = "lblProConlu";
            this.lblProConlu.Size = new System.Drawing.Size(120, 18);
            this.lblProConlu.TabIndex = 156;
            this.lblProConlu.Text = "Test Conculuant:";
            // 
            // pnlProf
            // 
            this.pnlProf.Controls.Add(this.rbProNC);
            this.pnlProf.Controls.Add(this.rbProC);
            this.pnlProf.Location = new System.Drawing.Point(659, 153);
            this.pnlProf.Name = "pnlProf";
            this.pnlProf.Size = new System.Drawing.Size(20, 64);
            this.pnlProf.TabIndex = 155;
            // 
            // rbProNC
            // 
            this.rbProNC.AutoSize = true;
            this.rbProNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProNC.Location = new System.Drawing.Point(3, 40);
            this.rbProNC.Name = "rbProNC";
            this.rbProNC.Size = new System.Drawing.Size(14, 13);
            this.rbProNC.TabIndex = 130;
            this.rbProNC.TabStop = true;
            this.rbProNC.Tag = "tagPfNC";
            this.rbProNC.UseVisualStyleBackColor = true;
            this.rbProNC.CheckedChanged += new System.EventHandler(this.rbProNC_CheckedChanged);
            this.rbProNC.Click += new System.EventHandler(this.rbTest_Click);
            // 
            // rbProC
            // 
            this.rbProC.AutoSize = true;
            this.rbProC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProC.Location = new System.Drawing.Point(3, 3);
            this.rbProC.Name = "rbProC";
            this.rbProC.Size = new System.Drawing.Size(14, 13);
            this.rbProC.TabIndex = 128;
            this.rbProC.TabStop = true;
            this.rbProC.Tag = "tagPfC";
            this.rbProC.UseVisualStyleBackColor = true;
            this.rbProC.CheckedChanged += new System.EventHandler(this.rbProC_CheckedChanged);
            this.rbProC.Click += new System.EventHandler(this.rbTest_Click);
            // 
            // lblTestProf
            // 
            this.lblTestProf.AutoSize = true;
            this.lblTestProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestProf.Location = new System.Drawing.Point(502, 114);
            this.lblTestProf.Name = "lblTestProf";
            this.lblTestProf.Size = new System.Drawing.Size(150, 18);
            this.lblTestProf.TabIndex = 154;
            this.lblTestProf.Text = "Test Professionnel";
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(307, 154);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(58, 20);
            this.txtMed.TabIndex = 158;
            this.txtMed.Tag = "tagMd";
            this.txtMed.Visible = false;
            this.txtMed.Click += new System.EventHandler(this.txtTest_Click);
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(685, 154);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(58, 20);
            this.txtProf.TabIndex = 159;
            this.txtProf.Tag = "tagPf";
            this.txtProf.Visible = false;
            this.txtProf.Click += new System.EventHandler(this.txtTest_Click);
            // 
            // UC_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.lblProNoConlu);
            this.Controls.Add(this.lblProConlu);
            this.Controls.Add(this.pnlProf);
            this.Controls.Add(this.lblTestProf);
            this.Controls.Add(this.lblMedNonConclut);
            this.Controls.Add(this.lblMedConclut);
            this.Controls.Add(this.pnlMed);
            this.Controls.Add(this.lblTitleMed);
            this.Name = "UC_Medecin";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_Medecin_Load);
            this.Leave += new System.EventHandler(this.UC_Medecin_Leave);
            this.pnlMed.ResumeLayout(false);
            this.pnlMed.PerformLayout();
            this.pnlProf.ResumeLayout(false);
            this.pnlProf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMed;
        private System.Windows.Forms.Panel pnlMed;
        private System.Windows.Forms.Label lblMedConclut;
        private System.Windows.Forms.Label lblMedNonConclut;
        private System.Windows.Forms.Label lblProNoConlu;
        private System.Windows.Forms.Label lblProConlu;
        private System.Windows.Forms.Panel pnlProf;
        private System.Windows.Forms.Label lblTestProf;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.TextBox txtProf;
        public System.Windows.Forms.RadioButton rbMedNC;
        public System.Windows.Forms.RadioButton rbMedC;
        public System.Windows.Forms.RadioButton rbProNC;
        public System.Windows.Forms.RadioButton rbProC;
    }
}
