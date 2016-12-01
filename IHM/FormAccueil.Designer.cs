namespace IHM
{
    partial class fnAccueil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fnAccueil));
            this.btQuitter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbModerateur = new System.Windows.Forms.GroupBox();
            this.btDeleteSujet = new System.Windows.Forms.Button();
            this.btDeleteRep = new System.Windows.Forms.Button();
            this.btModifSujet = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btAjoutSujet = new System.Windows.Forms.Button();
            this.btAjoutRep = new System.Windows.Forms.Button();
            this.dgvReponse = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbRubriques = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRub = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceSujet = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceRub = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSujet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSourceRep = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.gbModerateur.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbRubriques.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSujet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRep)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.SystemColors.GrayText;
            this.btQuitter.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btQuitter.Image")));
            this.btQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuitter.Location = new System.Drawing.Point(1007, 25);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(143, 38);
            this.btQuitter.TabIndex = 4;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbModerateur);
            this.panel3.Controls.Add(this.gbUser);
            this.panel3.Controls.Add(this.btQuitter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 72);
            this.panel3.TabIndex = 3;
            // 
            // gbModerateur
            // 
            this.gbModerateur.Controls.Add(this.btDeleteSujet);
            this.gbModerateur.Controls.Add(this.btDeleteRep);
            this.gbModerateur.Controls.Add(this.btModifSujet);
            this.gbModerateur.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModerateur.Location = new System.Drawing.Point(484, 3);
            this.gbModerateur.Name = "gbModerateur";
            this.gbModerateur.Size = new System.Drawing.Size(495, 66);
            this.gbModerateur.TabIndex = 6;
            this.gbModerateur.TabStop = false;
            this.gbModerateur.Text = "Action Modérateur";
            // 
            // btDeleteSujet
            // 
            this.btDeleteSujet.BackColor = System.Drawing.SystemColors.GrayText;
            this.btDeleteSujet.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteSujet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDeleteSujet.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteSujet.Image")));
            this.btDeleteSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleteSujet.Location = new System.Drawing.Point(337, 22);
            this.btDeleteSujet.Name = "btDeleteSujet";
            this.btDeleteSujet.Size = new System.Drawing.Size(143, 38);
            this.btDeleteSujet.TabIndex = 8;
            this.btDeleteSujet.Text = "Sujet";
            this.btDeleteSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeleteSujet.UseVisualStyleBackColor = false;
            this.btDeleteSujet.Click += new System.EventHandler(this.btDeleteSujet_Click);
            // 
            // btDeleteRep
            // 
            this.btDeleteRep.BackColor = System.Drawing.SystemColors.GrayText;
            this.btDeleteRep.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDeleteRep.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteRep.Image")));
            this.btDeleteRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleteRep.Location = new System.Drawing.Point(174, 22);
            this.btDeleteRep.Name = "btDeleteRep";
            this.btDeleteRep.Size = new System.Drawing.Size(143, 38);
            this.btDeleteRep.TabIndex = 7;
            this.btDeleteRep.Text = "Réponse";
            this.btDeleteRep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeleteRep.UseVisualStyleBackColor = false;
            this.btDeleteRep.Click += new System.EventHandler(this.btDeleteRep_Click);
            // 
            // btModifSujet
            // 
            this.btModifSujet.BackColor = System.Drawing.SystemColors.GrayText;
            this.btModifSujet.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifSujet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btModifSujet.Image = ((System.Drawing.Image)(resources.GetObject("btModifSujet.Image")));
            this.btModifSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModifSujet.Location = new System.Drawing.Point(14, 22);
            this.btModifSujet.Name = "btModifSujet";
            this.btModifSujet.Size = new System.Drawing.Size(143, 38);
            this.btModifSujet.TabIndex = 5;
            this.btModifSujet.Text = "Sujet";
            this.btModifSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModifSujet.UseVisualStyleBackColor = false;
            this.btModifSujet.Click += new System.EventHandler(this.btModifSujet_Click);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btAjoutSujet);
            this.gbUser.Controls.Add(this.btAjoutRep);
            this.gbUser.Font = new System.Drawing.Font("Broadway", 10F);
            this.gbUser.Location = new System.Drawing.Point(9, 3);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(363, 66);
            this.gbUser.TabIndex = 5;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Action Utilisateur";
            // 
            // btAjoutSujet
            // 
            this.btAjoutSujet.BackColor = System.Drawing.SystemColors.GrayText;
            this.btAjoutSujet.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutSujet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjoutSujet.Image = ((System.Drawing.Image)(resources.GetObject("btAjoutSujet.Image")));
            this.btAjoutSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjoutSujet.Location = new System.Drawing.Point(204, 22);
            this.btAjoutSujet.Name = "btAjoutSujet";
            this.btAjoutSujet.Size = new System.Drawing.Size(143, 38);
            this.btAjoutSujet.TabIndex = 6;
            this.btAjoutSujet.Text = "Sujet";
            this.btAjoutSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjoutSujet.UseVisualStyleBackColor = false;
            this.btAjoutSujet.Click += new System.EventHandler(this.btAjoutSujet_Click);
            // 
            // btAjoutRep
            // 
            this.btAjoutRep.BackColor = System.Drawing.SystemColors.GrayText;
            this.btAjoutRep.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjoutRep.Image = ((System.Drawing.Image)(resources.GetObject("btAjoutRep.Image")));
            this.btAjoutRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjoutRep.Location = new System.Drawing.Point(15, 22);
            this.btAjoutRep.Name = "btAjoutRep";
            this.btAjoutRep.Size = new System.Drawing.Size(143, 38);
            this.btAjoutRep.TabIndex = 5;
            this.btAjoutRep.Text = "Réponse";
            this.btAjoutRep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjoutRep.UseVisualStyleBackColor = false;
            this.btAjoutRep.Click += new System.EventHandler(this.btAjoutRep_Click);
            // 
            // dgvReponse
            // 
            this.dgvReponse.AllowUserToAddRows = false;
            this.dgvReponse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReponse.Location = new System.Drawing.Point(0, 0);
            this.dgvReponse.Name = "dgvReponse";
            this.dgvReponse.ReadOnly = true;
            this.dgvReponse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReponse.Size = new System.Drawing.Size(1178, 294);
            this.dgvReponse.TabIndex = 0;
            this.dgvReponse.TabStop = false;
            this.dgvReponse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReponse_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbRubriques, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.36612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.63388F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbRubriques
            // 
            this.gbRubriques.Controls.Add(this.label5);
            this.gbRubriques.Controls.Add(this.comboBoxSujet);
            this.gbRubriques.Controls.Add(this.label1);
            this.gbRubriques.Controls.Add(this.comboBoxRub);
            this.gbRubriques.Controls.Add(this.btnConnexion);
            this.gbRubriques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRubriques.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRubriques.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbRubriques.Location = new System.Drawing.Point(3, 97);
            this.gbRubriques.Name = "gbRubriques";
            this.gbRubriques.Size = new System.Drawing.Size(1178, 83);
            this.gbRubriques.TabIndex = 1;
            this.gbRubriques.TabStop = false;
            this.gbRubriques.Text = "Rubriques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choisir une rubrique";
            // 
            // comboBoxRub
            // 
            this.comboBoxRub.FormattingEnabled = true;
            this.comboBoxRub.Location = new System.Drawing.Point(41, 45);
            this.comboBoxRub.Name = "comboBoxRub";
            this.comboBoxRub.Size = new System.Drawing.Size(349, 32);
            this.comboBoxRub.TabIndex = 8;
            this.comboBoxRub.SelectedIndexChanged += new System.EventHandler(this.comboBoxRub_SelectedIndexChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnConnexion.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnexion.Image = ((System.Drawing.Image)(resources.GetObject("btnConnexion.Image")));
            this.btnConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnexion.Location = new System.Drawing.Point(985, 30);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(165, 42);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnexion.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReponse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 294);
            this.panel2.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelLogo.Controls.Add(this.label4);
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1178, 88);
            this.panelLogo.TabIndex = 4;
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
            // comboBoxSujet
            // 
            this.comboBoxSujet.FormattingEnabled = true;
            this.comboBoxSujet.Location = new System.Drawing.Point(508, 45);
            this.comboBoxSujet.Name = "comboBoxSujet";
            this.comboBoxSujet.Size = new System.Drawing.Size(349, 32);
            this.comboBoxSujet.TabIndex = 11;
            this.comboBoxSujet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSujet_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choisir un sujet";
            // 
            // fnAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "fnAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.fnAccueil_Load);
            this.panel3.ResumeLayout(false);
            this.gbModerateur.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReponse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbRubriques.ResumeLayout(false);
            this.gbRubriques.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSujet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvReponse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbRubriques;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRub;
        private System.Windows.Forms.BindingSource bindingSourceSujet;
        private System.Windows.Forms.BindingSource bindingSourceRub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbModerateur;
        private System.Windows.Forms.Button btDeleteSujet;
        private System.Windows.Forms.Button btDeleteRep;
        private System.Windows.Forms.Button btModifSujet;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btAjoutSujet;
        private System.Windows.Forms.Button btAjoutRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSujet;
        private System.Windows.Forms.BindingSource bindingSourceRep;
    }
}

