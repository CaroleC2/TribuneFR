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


        /* ----------------- Ne MARCHE PAS -------------------------*/
        //TODO
        private void btDeleteRep_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.SupprReponseText, Properties.Resources.SupprReponseTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (BLLOutils.BLL.DeleteReponse((int)dgvReponse.SelectedRows[0].Cells["IDREP"].Value) !=1)
                {
                   MessageBox.Show(Properties.Resources.SupprReponseText, Properties.Resources.SupprReponseTitre);
                }
                List<Reponse> reponses = BLL.ListReponsesByIdSujet((int)comboBoxSujet.SelectedValue);
                if (reponses != null)
                {
                    bindingSourceRep.DataSource = reponses;
                    dgvReponse.DataSource = bindingSourceRep;
                    dgvReponse.Columns["IDREP"].Visible = false;
                    dgvReponse.Columns["IDSUJET"].Visible = false;
                    dgvReponse.Columns["IDUSER"].Visible = false;

                    dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                    dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";
                }
            }

        }

        /* ----------------- Ne MARCHE PAS -------------------------*/
        
        private void btDeleteSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.SupprSujetText, Properties.Resources.SupprSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (BLLOutils.BLL.DeleteSujet((int)comboBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.ErreurSupprSujetText, Properties.Resources.ErreurSupprSujetTitre);
                }
                List<Sujet> sujets = BLL.ListSujetsByIdRub((int)comboBoxSujet.SelectedValue);
                if (sujets != null)
                {
                    dgvReponse.DataSource = bindingSourceRep;
                    dgvReponse.Columns["IDREP"].Visible = false;
                    dgvReponse.Columns["IDSUJET"].Visible = false;
                    dgvReponse.Columns["IDUSER"].Visible = false;

                    dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                    dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";



                    DialogResult res = MessageBox.Show("Voulez vous supprimer ce sujet ?", "Validation de la suppression",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        BLL.DeleteSujet((int)comboBoxSujet.SelectedValue);
                    }
                    
                }
            }

        }
        

           //TODO
           private void btModifSujet_Click(object sender, EventArgs e)
              {
            
            using (FormSujet formModifSujet = new FormSujet())
            {
                formModifSujet.rubrique = (Rubrique)comboBoxRub.SelectedItem;
                formModifSujet.sujet = (Sujet)comboBoxSujet.SelectedItem;
                formModifSujet.Text = string.Format("Modifier le sujet {0} dans la rubrique {1}", formModifSujet.sujet.TextSujet, formModifSujet.rubrique.NomRub);

                formModifSujet.ShowDialog();
                
                List<Sujet> sujets = BLL.ListSujetsByIdRub((int)comboBoxSujet.SelectedValue);

                dgvReponse.DataSource = bindingSourceRep;
                dgvReponse.Columns["IDREP"].Visible = false;
                dgvReponse.Columns["IDSUJET"].Visible = false;
                dgvReponse.Columns["IDUSER"].Visible = false;

                dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";

            }
            }

        /* ---------- EN COURS ------------------*/
        private void btAjoutSujet_Click(object sender, EventArgs e)
        {
            using (FormSujet formSujet = new FormSujet())
            {
                formSujet.rubrique = (Rubrique) comboBoxRub.SelectedItem;
                formSujet.Text = string.Format("Ajouter un sujet dans la rubrique {0}", formSujet.rubrique.NomRub);
                formSujet.ShowDialog();

                comboBoxSujet.DataSource = (BLL.ListSujetsByIdRub((int) comboBoxRub.SelectedValue));
            } 

        }

        private void btAjoutRep_Click(object sender, EventArgs e)
        {
            using (FormReponse formReponse = new FormReponse())
            {
                formReponse.sujet = (Sujet)comboBoxSujet.SelectedItem;
                formReponse.Text = string.Format("Poster une réponse au sujet {0}", formReponse.sujet.TitreSujet);
                formReponse.ShowDialog();
                
                List<Reponse> reponses = BLL.ListReponsesByIdSujet((int)comboBoxSujet.SelectedValue);

                dgvReponse.DataSource = bindingSourceRep;
                dgvReponse.Columns["IDREP"].Visible = false;
                dgvReponse.Columns["IDSUJET"].Visible = false;
                dgvReponse.Columns["IDUSER"].Visible = false;

                dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";

                //BLLOutils.BLL.NewReponse(Convert.ToInt32(formReponse.lbSujet.Text), formReponse.lbUser.Text,formReponse.txtBoxRep.Text, Convert.ToDateTime(formReponse.txtBoxRep.Text));

            }


           

        }

    private void btQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez-vous quitter l'application ?", "Quitter l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //private void dgvReponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            int CurrentRow = e.RowIndex;
        //            DataGridViewRow row = dgvReponse.Rows[CurrentRow];

        //            using (FormReponse formReponse = new FormReponse())
        //            {
        //                formReponse.reponse.TextRep = row.Cells["Texte"].Value.ToString();
        //                formReponse.ShowDialog();
        //            }



        //        }

        #endregion

        #region Quitter l'application 



    }

    
        #endregion

       
    }

   

