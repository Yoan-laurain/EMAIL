namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnv = new System.Windows.Forms.Button();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.lblServ = new System.Windows.Forms.Label();
            this.btnServ = new System.Windows.Forms.Button();
            this.btnSel1 = new System.Windows.Forms.Button();
            this.btnSel2 = new System.Windows.Forms.Button();
            this.btnSel3 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblCop = new System.Windows.Forms.Label();
            this.lblCopCach = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblObj = new System.Windows.Forms.Label();
            this.lblPiece = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.rtx1 = new System.Windows.Forms.RichTextBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnv
            // 
            this.btnEnv.Location = new System.Drawing.Point(15, 911);
            this.btnEnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnv.Name = "btnEnv";
            this.btnEnv.Size = new System.Drawing.Size(112, 35);
            this.btnEnv.TabIndex = 0;
            this.btnEnv.Text = "Envoyer";
            this.btnEnv.UseVisualStyleBackColor = true;
            this.btnEnv.Click += new System.EventHandler(this.btnEnvoiMail_Click);
            // 
            // cbx1
            // 
            this.cbx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(195, 165);
            this.cbx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx1.MaxDropDownItems = 15;
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(272, 28);
            this.cbx1.TabIndex = 1;
            this.cbx1.Click += new System.EventHandler(this.cbx1_Click);
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.BackColor = System.Drawing.Color.Transparent;
            this.lblServ.ForeColor = System.Drawing.SystemColors.Control;
            this.lblServ.Location = new System.Drawing.Point(18, 168);
            this.lblServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(111, 20);
            this.lblServ.TabIndex = 2;
            this.lblServ.Text = "Serveur SMTP";
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(537, 168);
            this.btnServ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(112, 35);
            this.btnServ.TabIndex = 3;
            this.btnServ.Text = "Serveurs";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // btnSel1
            // 
            this.btnSel1.Location = new System.Drawing.Point(537, 237);
            this.btnSel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSel1.Name = "btnSel1";
            this.btnSel1.Size = new System.Drawing.Size(112, 35);
            this.btnSel1.TabIndex = 4;
            this.btnSel1.Text = "Selectionner";
            this.btnSel1.UseVisualStyleBackColor = true;
            this.btnSel1.Click += new System.EventHandler(this.btnSel1_Click);
            // 
            // btnSel2
            // 
            this.btnSel2.Location = new System.Drawing.Point(537, 315);
            this.btnSel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSel2.Name = "btnSel2";
            this.btnSel2.Size = new System.Drawing.Size(112, 35);
            this.btnSel2.TabIndex = 5;
            this.btnSel2.Text = "Selectionner";
            this.btnSel2.UseVisualStyleBackColor = true;
            this.btnSel2.Click += new System.EventHandler(this.btnSel2_Click);
            // 
            // btnSel3
            // 
            this.btnSel3.Location = new System.Drawing.Point(537, 394);
            this.btnSel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSel3.Name = "btnSel3";
            this.btnSel3.Size = new System.Drawing.Size(112, 35);
            this.btnSel3.TabIndex = 6;
            this.btnSel3.Text = "Selectionner";
            this.btnSel3.UseVisualStyleBackColor = true;
            this.btnSel3.Click += new System.EventHandler(this.btnSel3_Click);
            // 
            // btnA4
            // 
            this.btnA4.Location = new System.Drawing.Point(537, 592);
            this.btnA4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(112, 35);
            this.btnA4.TabIndex = 7;
            this.btnA4.Text = "Ajouter";
            this.btnA4.UseVisualStyleBackColor = true;
            this.btnA4.Click += new System.EventHandler(this.btnA4_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(195, 237);
            this.tbx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(272, 26);
            this.tbx1.TabIndex = 8;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(195, 315);
            this.tbx2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(272, 26);
            this.tbx2.TabIndex = 9;
            this.tbx2.TextChanged += new System.EventHandler(this.tbx2_TextChanged);
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(195, 394);
            this.tbx3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(272, 26);
            this.tbx3.TabIndex = 10;
            this.tbx3.TextChanged += new System.EventHandler(this.tbx3_TextChanged);
            // 
            // tbx6
            // 
            this.tbx6.Enabled = false;
            this.tbx6.Location = new System.Drawing.Point(195, 595);
            this.tbx6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(272, 26);
            this.tbx6.TabIndex = 11;
            // 
            // tbx5
            // 
            this.tbx5.Location = new System.Drawing.Point(195, 528);
            this.tbx5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(272, 26);
            this.tbx5.TabIndex = 12;
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(195, 465);
            this.tbx4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(272, 26);
            this.tbx4.TabIndex = 13;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.BackColor = System.Drawing.Color.Transparent;
            this.lblDest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDest.Location = new System.Drawing.Point(18, 245);
            this.lblDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(95, 20);
            this.lblDest.TabIndex = 14;
            this.lblDest.Text = "Destinataire";
            // 
            // lblCop
            // 
            this.lblCop.AutoSize = true;
            this.lblCop.BackColor = System.Drawing.Color.Transparent;
            this.lblCop.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCop.Location = new System.Drawing.Point(21, 320);
            this.lblCop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCop.Name = "lblCop";
            this.lblCop.Size = new System.Drawing.Size(50, 20);
            this.lblCop.TabIndex = 15;
            this.lblCop.Text = "Copie";
            // 
            // lblCopCach
            // 
            this.lblCopCach.AutoSize = true;
            this.lblCopCach.BackColor = System.Drawing.Color.Transparent;
            this.lblCopCach.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCopCach.Location = new System.Drawing.Point(18, 402);
            this.lblCopCach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopCach.Name = "lblCopCach";
            this.lblCopCach.Size = new System.Drawing.Size(106, 20);
            this.lblCopCach.TabIndex = 16;
            this.lblCopCach.Text = "Copie cachée";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.BackColor = System.Drawing.Color.Transparent;
            this.lblExp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExp.Location = new System.Drawing.Point(18, 469);
            this.lblExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(85, 20);
            this.lblExp.TabIndex = 17;
            this.lblExp.Text = "Expediteur";
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.BackColor = System.Drawing.Color.Transparent;
            this.lblObj.ForeColor = System.Drawing.Color.Transparent;
            this.lblObj.Location = new System.Drawing.Point(21, 538);
            this.lblObj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(47, 20);
            this.lblObj.TabIndex = 18;
            this.lblObj.Text = "Objet";
            // 
            // lblPiece
            // 
            this.lblPiece.AutoSize = true;
            this.lblPiece.BackColor = System.Drawing.Color.Transparent;
            this.lblPiece.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPiece.Location = new System.Drawing.Point(18, 606);
            this.lblPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiece.Name = "lblPiece";
            this.lblPiece.Size = new System.Drawing.Size(106, 20);
            this.lblPiece.TabIndex = 19;
            this.lblPiece.Text = "Pieces jointes";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titre.Location = new System.Drawing.Point(231, 37);
            this.Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(195, 61);
            this.Titre.TabIndex = 20;
            this.Titre.Text = "DbMail";
            // 
            // rtx1
            // 
            this.rtx1.Location = new System.Drawing.Point(132, 674);
            this.rtx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtx1.Name = "rtx1";
            this.rtx1.Size = new System.Drawing.Size(460, 164);
            this.rtx1.TabIndex = 21;
            this.rtx1.Text = "";
            this.rtx1.Click += new System.EventHandler(this.rtx1_Click);
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(195, 911);
            this.btnCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(112, 35);
            this.btnCont.TabIndex = 22;
            this.btnCont.Text = "Contacts";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(375, 911);
            this.btnAnnul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(112, 35);
            this.btnAnnul.TabIndex = 23;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(537, 911);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 35);
            this.btnQuit.TabIndex = 24;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.db2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 965);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.rtx1);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.lblPiece);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblCopCach);
            this.Controls.Add(this.lblCop);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.btnA4);
            this.Controls.Add(this.btnSel3);
            this.Controls.Add(this.btnSel2);
            this.Controls.Add(this.btnSel1);
            this.Controls.Add(this.btnServ);
            this.Controls.Add(this.lblServ);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.btnEnv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BOITE MAIL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnv;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.Button btnSel1;
        private System.Windows.Forms.Button btnSel2;
        private System.Windows.Forms.Button btnSel3;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx6;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblCop;
        private System.Windows.Forms.Label lblCopCach;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.Label lblPiece;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.RichTextBox rtx1;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnQuit;
    }
}

