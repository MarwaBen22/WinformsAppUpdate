
namespace GRHApp.UserControls
{
    partial class UC_DoYouKnow
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
            this.txtFName1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lblFNames = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.txtJob1 = new System.Windows.Forms.TextBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.txtJob2 = new System.Windows.Forms.TextBox();
            this.txtFName2 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(144, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(490, 18);
            this.lblTitle.TabIndex = 146;
            this.lblTitle.Text = "Connaissez-vous des personnes au niveau de CSC ? Si oui, les quelles ?";
            // 
            // txtFName1
            // 
            this.txtFName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName1.Location = new System.Drawing.Point(278, 149);
            this.txtFName1.Name = "txtFName1";
            this.txtFName1.Size = new System.Drawing.Size(150, 24);
            this.txtFName1.TabIndex = 150;
            this.txtFName1.Tag = "tagFNam1";
            this.txtFName1.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName1.Location = new System.Drawing.Point(278, 179);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(150, 24);
            this.txtName1.TabIndex = 148;
            this.txtName1.Tag = "tagNam1";
            this.txtName1.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblFNames
            // 
            this.lblFNames.AutoSize = true;
            this.lblFNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNames.Location = new System.Drawing.Point(194, 182);
            this.lblFNames.Name = "lblFNames";
            this.lblFNames.Size = new System.Drawing.Size(73, 18);
            this.lblFNames.TabIndex = 149;
            this.lblFNames.Text = "Prénoms:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(194, 155);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(53, 18);
            this.lblNames.TabIndex = 147;
            this.lblNames.Text = "Noms:";
            // 
            // txtJob1
            // 
            this.txtJob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob1.Location = new System.Drawing.Point(278, 209);
            this.txtJob1.Name = "txtJob1";
            this.txtJob1.Size = new System.Drawing.Size(150, 24);
            this.txtJob1.TabIndex = 151;
            this.txtJob1.Tag = "tagJob1";
            this.txtJob1.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(194, 212);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(78, 18);
            this.lblPost.TabIndex = 152;
            this.lblPost.Text = "Fonctions:";
            // 
            // txtJob2
            // 
            this.txtJob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob2.Location = new System.Drawing.Point(434, 209);
            this.txtJob2.Name = "txtJob2";
            this.txtJob2.Size = new System.Drawing.Size(150, 24);
            this.txtJob2.TabIndex = 155;
            this.txtJob2.Tag = "tagJob2";
            this.txtJob2.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtFName2
            // 
            this.txtFName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName2.Location = new System.Drawing.Point(434, 149);
            this.txtFName2.Name = "txtFName2";
            this.txtFName2.Size = new System.Drawing.Size(150, 24);
            this.txtFName2.TabIndex = 154;
            this.txtFName2.Tag = "tagFNam2";
            this.txtFName2.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName2.Location = new System.Drawing.Point(434, 179);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(150, 24);
            this.txtName2.TabIndex = 153;
            this.txtName2.Tag = "tagNam2";
            this.txtName2.Click += new System.EventHandler(this.txt_Click);
            // 
            // UC_DoYouKnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtJob2);
            this.Controls.Add(this.txtFName2);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtJob1);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.txtFName1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lblFNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_DoYouKnow";
            this.Size = new System.Drawing.Size(778, 410);
            this.Load += new System.EventHandler(this.UC_DoYouKnow_Load);
            this.Leave += new System.EventHandler(this.UC_DoYouKnow_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtFName1;
        public System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblFNames;
        private System.Windows.Forms.Label lblNames;
        public System.Windows.Forms.TextBox txtJob1;
        private System.Windows.Forms.Label lblPost;
        public System.Windows.Forms.TextBox txtJob2;
        public System.Windows.Forms.TextBox txtFName2;
        public System.Windows.Forms.TextBox txtName2;
    }
}
