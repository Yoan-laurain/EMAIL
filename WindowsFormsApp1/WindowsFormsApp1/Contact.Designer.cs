namespace WindowsFormsApp1
{
    partial class Contact
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAj = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnTer = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(107, 97);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(135, 161);
            this.dgv1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl1.Location = new System.Drawing.Point(79, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(163, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Contacts";
            // 
            // btnAj
            // 
            this.btnAj.Location = new System.Drawing.Point(35, 321);
            this.btnAj.Name = "btnAj";
            this.btnAj.Size = new System.Drawing.Size(75, 23);
            this.btnAj.TabIndex = 2;
            this.btnAj.Text = "Ajouter";
            this.btnAj.UseVisualStyleBackColor = true;
            this.btnAj.Click += new System.EventHandler(this.btnAj_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(116, 321);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(75, 23);
            this.btnSup.TabIndex = 3;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnTer
            // 
            this.btnTer.Location = new System.Drawing.Point(197, 321);
            this.btnTer.Name = "btnTer";
            this.btnTer.Size = new System.Drawing.Size(75, 23);
            this.btnTer.TabIndex = 4;
            this.btnTer.Text = "Terminer";
            this.btnTer.UseVisualStyleBackColor = true;
            this.btnTer.Click += new System.EventHandler(this.btnTer_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(57, 283);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(206, 20);
            this.tbx1.TabIndex = 5;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.db2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 350);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.btnTer);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnAj);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(360, 350);
            this.MinimumSize = new System.Drawing.Size(360, 350);
            this.Name = "Contact";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAj;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnTer;
        private System.Windows.Forms.TextBox tbx1;
    }
}