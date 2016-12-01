namespace IHM
{
    partial class FormReponse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReponse));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.txtBoxRep = new System.Windows.Forms.RichTextBox();
            this.btAjoutRep = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateEnvoi = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceRep = new System.Windows.Forms.BindingSource(this.components);
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.lbIdSujet = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSujet = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRep)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 464F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1178, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSujet);
            this.groupBox1.Controls.Add(this.lbUser);
            this.groupBox1.Controls.Add(this.lbIdSujet);
            this.groupBox1.Controls.Add(this.lbNomUtilisateur);
            this.groupBox1.Controls.Add(this.btQuitter);
            this.groupBox1.Controls.Add(this.txtBoxRep);
            this.groupBox1.Controls.Add(this.btAjoutRep);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDateEnvoi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout Réponse";
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btQuitter.BackColor = System.Drawing.SystemColors.GrayText;
            this.btQuitter.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btQuitter.Image")));
            this.btQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuitter.Location = new System.Drawing.Point(902, 266);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(198, 38);
            this.btQuitter.TabIndex = 5;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            // 
            // txtBoxRep
            // 
            this.txtBoxRep.Location = new System.Drawing.Point(118, 76);
            this.txtBoxRep.Name = "txtBoxRep";
            this.txtBoxRep.Size = new System.Drawing.Size(609, 317);
            this.txtBoxRep.TabIndex = 18;
            this.txtBoxRep.Text = "";
            // 
            // btAjoutRep
            // 
            this.btAjoutRep.BackColor = System.Drawing.SystemColors.GrayText;
            this.btAjoutRep.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjoutRep.Image = ((System.Drawing.Image)(resources.GetObject("btAjoutRep.Image")));
            this.btAjoutRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjoutRep.Location = new System.Drawing.Point(902, 139);
            this.btAjoutRep.Name = "btAjoutRep";
            this.btAjoutRep.Size = new System.Drawing.Size(198, 41);
            this.btAjoutRep.TabIndex = 10;
            this.btAjoutRep.Text = "Poster Réponse";
            this.btAjoutRep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjoutRep.UseVisualStyleBackColor = false;
            this.btAjoutRep.Click += new System.EventHandler(this.btAjoutRep_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(237, 39);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 17;
            this.lbDate.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Texte";
            // 
            // lblDateEnvoi
            // 
            this.lblDateEnvoi.AutoSize = true;
            this.lblDateEnvoi.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnvoi.Location = new System.Drawing.Point(14, 33);
            this.lblDateEnvoi.Name = "lblDateEnvoi";
            this.lblDateEnvoi.Size = new System.Drawing.Size(180, 19);
            this.lblDateEnvoi.TabIndex = 14;
            this.lblDateEnvoi.Text = "Date Envoi Réponse";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelLogo.Controls.Add(this.label4);
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Location = new System.Drawing.Point(3, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1178, 88);
            this.panelLogo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(720, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 58);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(432, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tribune";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "2isa";
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomUtilisateur.Location = new System.Drawing.Point(369, 33);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(146, 19);
            this.lbNomUtilisateur.TabIndex = 19;
            this.lbNomUtilisateur.Text = "Nom Utilisateur";
            // 
            // lbIdSujet
            // 
            this.lbIdSujet.AutoSize = true;
            this.lbIdSujet.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdSujet.Location = new System.Drawing.Point(699, 31);
            this.lbIdSujet.Name = "lbIdSujet";
            this.lbIdSujet.Size = new System.Drawing.Size(77, 19);
            this.lbIdSujet.TabIndex = 20;
            this.lbIdSujet.Text = "Id Sujet";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(566, 39);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 13);
            this.lbUser.TabIndex = 21;
            this.lbUser.Text = "Utilisateur";
            // 
            // lbSujet
            // 
            this.lbSujet.AutoSize = true;
            this.lbSujet.Location = new System.Drawing.Point(910, 37);
            this.lbSujet.Name = "lbSujet";
            this.lbSujet.Size = new System.Drawing.Size(40, 13);
            this.lbSujet.TabIndex = 22;
            this.lbSujet.Text = "IdSujet";
            // 
            // FormReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormReponse";
            this.Text = "Réponse";
            this.Load += new System.EventHandler(this.FormReponse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAjoutRep;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateEnvoi;
        private System.Windows.Forms.RichTextBox txtBoxRep;
        private System.Windows.Forms.BindingSource bindingSourceRep;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbSujet;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbIdSujet;
        private System.Windows.Forms.Label lbNomUtilisateur;
    }
}