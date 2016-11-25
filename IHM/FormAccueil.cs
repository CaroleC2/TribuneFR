using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLOutils;
using Metier;

namespace IHM
{

  
    public partial class fnAccueil : Form
    {
        
        //BLL blloutils = new BLL();
        public fnAccueil()
        {
            InitializeComponent();
            //L'IHM s'adresse directement aux classes d'accès aux données
        
        }
        #region Load Fenêtre
        private void fnAccueil_Load(object sender, EventArgs e)
        {
            //Utilise des methodes d'accès qui renvoient un Dataset 
            //bindingSourceRub.DataSource = objRubDAO.GetRubriques().Tables[0];
            
            comboBoxRub.DisplayMember = "nomrub";
            comboBoxRub.ValueMember = "idrub";
            comboBoxRub.DataSource = BLL.ListAllRubriques();
            comboBoxRub.SelectedIndex = 0;
            List<Sujet> sujets = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));
            dgvSujet.DataSource = sujets; 

        
        }

        #endregion

        #region Action Utilisateur

        private void comboBoxRub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRub.SelectedValue != null)
            {
                //Utilise des methodes d'accès qui renvoient un Dataset 
                bindingSourceRub.DataSource = BLL.ListRubriquesById(int.Parse(comboBoxRub.SelectedValue.ToString()));
                bindingSourceSujet.DataSource = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));
                dgvSujet.DataSource = bindingSourceSujet;
                dgvSujet.Columns["IDSUJET"].Visible = false;
                dgvSujet.Columns["IDRUB"].Visible = false;
                dgvSujet.Columns["IDUSER"].Visible = false;
                dgvSujet.Columns["TITRESUJET"].HeaderText = "Titre";
                dgvSujet.Columns["TEXTSUJET"].HeaderText = "Texte";
                dgvSujet.Columns["DATECREATSUJET"].HeaderText = "Date de création";
                //TODO ###################### TRIER LES COLONNES ###############################

            }
        }
        #endregion

        #region Quitter l'application 

        private void btQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez-vous quitter l'application ?", "Quitter l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            //this.Close();
        }




        #endregion

       
    }
}
