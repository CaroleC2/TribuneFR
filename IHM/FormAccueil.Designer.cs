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
            this.dgvSujet = new System.Windows.Forms.DataGridView();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSujet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbRubriques.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSujet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRub)).BeginInit();
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
            this.panel3.Controls.Add(this.btQuitter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 72);
            this.panel3.TabIndex = 3;
            // 
            // dgvSujet
            // 
            this.dgvSujet.AllowUserToAddRows = false;
            this.dgvSujet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSujet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSujet.Location = new System.Drawing.Point(0, 0);
            this.dgvSujet.Name = "dgvSujet";
            this.dgvSujet.ReadOnly = true;
            this.dgvSujet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSujet.Size = new System.Drawing.Size(1178, 294);
            this.dgvSujet.TabIndex = 0;
            this.dgvSujet.TabStop = false;
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
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choisir une rubrique";
            // 
            // comboBoxRub
            // 
            this.comboBoxRub.FormattingEnabled = true;
            this.comboBoxRub.Location = new System.Drawing.Point(292, 29);
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
            this.btnConnexion.Location = new System.Drawing.Point(985, 19);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(165, 42);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnexion.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSujet);
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
            // fnAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "fnAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.fnAccueil_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSujet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbRubriques.ResumeLayout(false);
            this.gbRubriques.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSujet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSujet;
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
    }
}

