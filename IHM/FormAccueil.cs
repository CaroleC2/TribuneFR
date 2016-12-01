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
        
        
        public fnAccueil()
        {
            InitializeComponent();
            //L'IHM s'adresse directement aux classes d'accès aux données
        
        }
        #region Load Fenêtre
        private void fnAccueil_Load(object sender, EventArgs e)
        {
          
            //ComboBox Rubrique
            comboBoxRub.DisplayMember = "nomrub";
            comboBoxRub.ValueMember = "idrub";
            comboBoxRub.DataSource = BLL.ListAllRubriques();
            comboBoxRub.SelectedIndex = 0;
            List<Sujet> sujets = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));
            
            
            //ComboBox Sujet
            comboBoxSujet.DisplayMember = "titresujet";
            comboBoxSujet.ValueMember = "idsujet";
            comboBoxSujet.DataSource = sujets;
            comboBoxSujet.SelectedIndex = 0;
            List<Reponse> reponses = BLL.ListReponsesByIdSujet(int.Parse(comboBoxSujet.SelectedValue.ToString()));
            dgvReponse.DataSource = reponses;

        }

        #endregion

        #region Action Utilisateur

        private void comboBoxRub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRub.SelectedValue != null)
            {
                //Utilise des methodes d'accès qui renvoient un Dataset 
                
                List<Sujet> sujets = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));
                
                //ComboBox Sujet
                comboBoxSujet.DisplayMember = "titresujet";
                comboBoxSujet.ValueMember = "idsujet";
                comboBoxSujet.DataSource = sujets;
                
            }
        }



        private void comboBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSujet != null)
            {
                
                bindingSourceRep.DataSource = BLL.ListReponsesByIdSujet(int.Parse(comboBoxSujet.SelectedValue.ToString()));
            }

            dgvReponse.DataSource = bindingSourceRep;
            dgvReponse.Columns["IDREP"].Visible = false;
            dgvReponse.Columns["IDSUJET"].Visible = false;
            dgvReponse.Columns["IDUSER"].Visible = false;

            dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
            dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";


        }

        private void btDeleteRep_Click(object sender, EventArgs e)
        {
            int idrep = Convert.ToInt32(dgvReponse.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Voulez vous supprimer cette réponse ?", "Validation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                
                
            }

        }

        private void btDeleteSujet_Click(object sender, EventArgs e)
        {
            //int idrep = Convert.ToInt32(dgvReponse.CurrentRow.Cells[1].Value);


            
            ////if (dgvReponse.)
            //{
            //    MessageBox.Show("Voulez vous supprimer ce sujet ?", "Validation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes
            //}


        }

        private void btModifSujet_Click(object sender, EventArgs e)
        {
            
           

        }

        private void btAjoutSujet_Click(object sender, EventArgs e)
        {
            //Test ajout d'un sujet
            string titreSujet = txtBoxTitre.Text;
            string textSujet = txtBoxTexte.Text;
            DateTime dateCreatSujet = txtBoxDate.Text;

            BLLOutils.BLL.NewSujets(txtBoxTitre.Text, txtBoxTexte.Text, txtBoxDate.Text);

         

        }

        private void btAjoutRep_Click(object sender, EventArgs e)
        {
            //Test ajout d'un réponse
            int idUser = Convert.ToInt32(txtBoxIdUser.Text);
            int idSujet = Convert.ToInt32(txtBoxIdSujet.Text);
            string textRep = txtBoxTextRep.Text;

            BLLOutils.BLL.NewReponses(txtBoxIdUser.Text, txtBoxIdSujet.Text, txtBoxTextRep.Text);
            
        }

        private void dgvReponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRow = e.RowIndex;
            DataGridViewRow row = dgvReponse.Rows[CurrentRow];

            using (FormReponse formReponse = new FormReponse())
            {
                formReponse.reponse.TextRep = row.Cells["Texte"].Value.ToString();
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
