
namespace GRHApp.UserControls
{
    partial class UC_RequestOrigine
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl1Choice = new System.Windows.Forms.Label();
            this.lbl2Choice = new System.Windows.Forms.Label();
            this.lbl3Choice = new System.Windows.Forms.Label();
            this.lblOtherChoice = new System.Windows.Forms.Label();
            this.onlChoices = new System.Windows.Forms.Panel();
            this.rb2Choice = new System.Windows.Forms.RadioButton();
            this.rb3Choice = new System.Windows.Forms.RadioButton();
            this.rb1Choice = new System.Windows.Forms.RadioButton();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.onlChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(176, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 18);
            this.lblTitle.TabIndex = 145;
            this.lblTitle.Text = "Origine de demande de recrutement suite a:";
            // 
            // lbl1Choice
            // 
            this.lbl1Choice.AutoSize = true;
            this.lbl1Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Choice.Location = new System.Drawing.Point(216, 144);
            this.lbl1Choice.Name = "lbl1Choice";
            this.lbl1Choice.Size = new System.Drawing.Size(306, 18);
            this.lbl1Choice.TabIndex = 146;
            this.lbl1Choice.Text = "* Avis de recrutement paru par voie de presse";
            // 
            // lbl2Choice
            // 
            this.lbl2Choice.AutoSize = true;
            this.lbl2Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Choice.Location = new System.Drawing.Point(216, 181);
            this.lbl2Choice.Name = "lbl2Choice";
            this.lbl2Choice.Size = new System.Drawing.Size(341, 18);
            this.lbl2Choice.TabIndex = 147;
            this.lbl2Choice.Text = "* Recommandation par le bureau de main d\'oeuvre";
            // 
            // lbl3Choice
            // 
            this.lbl3Choice.AutoSize = true;
            this.lbl3Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Choice.Location = new System.Drawing.Point(216, 218);
            this.lbl3Choice.Name = "lbl3Choice";
            this.lbl3Choice.Size = new System.Drawing.Size(303, 18);
            this.lbl3Choice.TabIndex = 148;
            this.lbl3Choice.Text = "* Recommandation par un travailleur de CSC";
            // 
            // lblOtherChoice
            // 
            this.lblOtherChoice.AutoSize = true;
            this.lblOtherChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherChoice.Location = new System.Drawing.Point(216, 255);
            this.lblOtherChoice.Name = "lblOtherChoice";
            this.lblOtherChoice.Size = new System.Drawing.Size(18, 18);
            this.lblOtherChoice.TabIndex = 149;
            this.lblOtherChoice.Text = "* ";
            // 
            // onlChoices
            // 
            this.onlChoices.Controls.Add(this.rb2Choice);
            this.onlChoices.Controls.Add(this.rb3Choice);
            this.onlChoices.Controls.Add(this.rb1Choice);
            this.onlChoices.Location = new System.Drawing.Point(583, 144);
            this.onlChoices.Name = "onlChoices";
            this.onlChoices.Size = new System.Drawing.Size(20, 100);
            this.onlChoices.TabIndex = 150;
            // 
            // rb2Choice
            // 
            this.rb2Choice.AutoSize = true;
            this.rb2Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2Choice.Location = new System.Drawing.Point(3, 40);
            this.rb2Choice.Name = "rb2Choice";
            this.rb2Choice.Size = new System.Drawing.Size(14, 13);
            this.rb2Choice.TabIndex = 130;
            this.rb2Choice.TabStop = true;
            this.rb2Choice.Tag = "tagChoi2";
            this.rb2Choice.UseVisualStyleBackColor = true;
            this.rb2Choice.CheckedChanged += new System.EventHandler(this.rb2Choice_CheckedChanged);
            this.rb2Choice.Click += new System.EventHandler(this.rbChoice_Click);
            // 
            // rb3Choice
            // 
            this.rb3Choice.AutoSize = true;
            this.rb3Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3Choice.Location = new System.Drawing.Point(3, 77);
            this.rb3Choice.Name = "rb3Choice";
            this.rb3Choice.Size = new System.Drawing.Size(14, 13);
            this.rb3Choice.TabIndex = 129;
            this.rb3Choice.TabStop = true;
            this.rb3Choice.Tag = "tagChoi3";
            this.rb3Choice.UseVisualStyleBackColor = true;
            this.rb3Choice.CheckedChanged += new System.EventHandler(this.rb3Choice_CheckedChanged);
            this.rb3Choice.Click += new System.EventHandler(this.rbChoice_Click);
            // 
            // rb1Choice
            // 
            this.rb1Choice.AutoSize = true;
            this.rb1Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1Choice.Location = new System.Drawing.Point(3, 3);
            this.rb1Choice.Name = "rb1Choice";
            this.rb1Choice.Size = new System.Drawing.Size(14, 13);
            this.rb1Choice.TabIndex = 128;
            this.rb1Choice.TabStop = true;
            this.rb1Choice.Tag = "tagChoi1";
            this.rb1Choice.UseVisualStyleBackColor = true;
            this.rb1Choice.CheckedChanged += new System.EventHandler(this.rb1Choice_CheckedChanged);
            this.rb1Choice.Click += new System.EventHandler(this.rbChoice_Click);
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(240, 252);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(279, 24);
            this.txtOther.TabIndex = 151;
            this.txtOther.Tag = "tagOthers";
            this.txtOther.Click += new System.EventHandler(this.txtOther_Click);
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(609, 179);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(49, 20);
            this.txtChoice.TabIndex = 152;
            this.txtChoice.Tag = "tagChoice";
            this.txtChoice.Visible = false;
            this.txtChoice.Click += new System.EventHandler(this.txtOther_Click);
            // 
            // UC_RequestOrigine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.onlChoices);
            this.Controls.Add(this.lblOtherChoice);
            this.Controls.Add(this.lbl3Choice);
            this.Controls.Add(this.lbl2Choice);
            this.Controls.Add(this.lbl1Choice);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_RequestOrigine";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_RequestOrigine_Load);
            this.Leave += new System.EventHandler(this.UC_RequestOrigine_Leave);
            this.onlChoices.ResumeLayout(false);
            this.onlChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl1Choice;
        private System.Windows.Forms.Label lbl2Choice;
        private System.Windows.Forms.Label lbl3Choice;
        private System.Windows.Forms.Label lblOtherChoice;
        private System.Windows.Forms.Panel onlChoices;
        private System.Windows.Forms.RadioButton rb2Choice;
        private System.Windows.Forms.RadioButton rb3Choice;
        private System.Windows.Forms.RadioButton rb1Choice;
        public System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtChoice;
    }
}
