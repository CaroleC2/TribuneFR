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
using TribuneDevMETIER;

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
            dgvReponse.Visible = true;

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


            //TxtBox Sujet
            bindingSourceSujet.DataSource = sujets;
            Sujet sujetCourant = (Sujet)comboBoxSujet.SelectedItem;
            txtBoxSujet.Text = sujetCourant.TextSujet;



        }

        #endregion

        #region Action Utilisateur

        private void comboBoxRub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRub.SelectedValue != null)
            {
                List<Sujet> sujets = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));

                if (sujets.Count != 0)
                {
                    //ComboBox Sujet
                    comboBoxSujet.DisplayMember = "titresujet";
                    comboBoxSujet.ValueMember = "idsujet";
                    comboBoxSujet.DataSource = sujets;

                    bindingSourceSujet.DataSource = sujets;
                    Sujet sujetCourant = (Sujet)comboBoxSujet.SelectedItem;

                    if (sujetCourant != null)
                    {
                        labelError.Visible = false;
                        btDeleteRep.Visible = true;
                        btDeleteSujet.Visible = true;
                        btModifSujet.Visible = true;
                        btAjoutRep.Visible = true;
                        txtBoxSujet.Text = sujetCourant.TextSujet;
                        comboBoxSujet.Enabled = true;
                    }
                    
                }
                    else
                    {
                        txtBoxSujet.Text = "";
                        dgvReponse.Visible = false;
                        labelError.Text = "La rubrique sélectionnée ne comporte pas de sujets";
                        labelError.Visible = true;
                        btDeleteRep.Visible = false;
                        btDeleteSujet.Visible = false;
                        btModifSujet.Visible = false;
                        btAjoutRep.Visible = false;
                        comboBoxSujet.DataSource = null;
                        comboBoxSujet.Enabled = false;
                    }
            }
        }
        
        private void comboBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSujet.SelectedItem != null)
            {
                List<Reponse> reponses = BLL.ListReponsesByIdSujet(int.Parse(comboBoxSujet.SelectedValue.ToString()));
                if ( reponses.Count != 0)
                {
                    bindingSourceRep.DataSource = reponses;
                    dgvReponse.Visible = true;
                    labelError.Visible = false;
                    btDeleteRep.Visible = true;
                    dgvReponse.DataSource = bindingSourceRep;
                    dgvReponse.Columns["IDREP"].Visible = false;
                    dgvReponse.Columns["IDSUJET"].Visible = false;
                    dgvReponse.Columns["IDUSER"].Visible = false;
               
                    dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                    dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";
                }
                else
                {
                    dgvReponse.Visible = false;
                    labelError.Text = "Le sujet sélectionné ne comporte pas de réponses";
                    labelError.Visible = true;
                    btDeleteRep.Visible = false;
                }
                Sujet sujetCourant = (Sujet)comboBoxSujet.SelectedItem;
                txtBoxSujet.Text = sujetCourant.TextSujet;
            }
            
            
        }
        
        private void btDeleteRep_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.SupprReponseText, Properties.Resources.SupprReponseTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (BLLOutils.BLL.DeleteReponse((int)dgvReponse.SelectedRows[0].Cells["IDREP"].Value) !=1)
                {
                   MessageBox.Show(Properties.Resources.SupprReponseText, Properties.Resources.SupprReponseTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                    bindingSourceRep.DataSource = reponses;
                }
            }

        }
        
        private void btDeleteSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.SupprSujetText, Properties.Resources.SupprSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (BLLOutils.BLL.DeleteSujet((int)comboBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.ErreurSupprSujetText, Properties.Resources.ErreurSupprSujetTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    bindingSourceRep.DataSource = sujets;

                }
            }

        }
        
        private void btAjoutSujet_Click(object sender, EventArgs e)
        {
            using (FormSujet formSujet = new FormSujet())
            {
                formSujet.modif = false;
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

                if(bindingSourceRep.Count !=0)
                { 
                    dgvReponse.DataSource = bindingSourceRep;
                    dgvReponse.Columns["IDREP"].Visible = false;
                    dgvReponse.Columns["IDSUJET"].Visible = false;
                    dgvReponse.Columns["IDUSER"].Visible = false;

                    dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                    dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";
                    bindingSourceRep.DataSource = reponses ;
                }
               
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

        private void btModifSujet_Click_1(object sender, EventArgs e)
        {
            using (FormSujet formModifSujet = new FormSujet())
            {
                formModifSujet.modif = true;
                formModifSujet.rubrique = (Rubrique)comboBoxRub.SelectedItem;
                formModifSujet.sujet = (Sujet)comboBoxSujet.SelectedItem;

                formModifSujet.Text = string.Format("Modifier le sujet {0} dans la rubrique {1}", formModifSujet.sujet.TextSujet, formModifSujet.rubrique.NomRub);

                formModifSujet.ShowDialog();


            }
            List<Sujet> sujets = BLL.ListSujetsByIdRub((int)comboBoxRub.SelectedValue);
            comboBoxSujet.DataSource = sujets;
            if (bindingSourceRep.Count != 0)
            {
                dgvReponse.DataSource = bindingSourceRep;
                dgvReponse.Columns["IDREP"].Visible = false;
                dgvReponse.Columns["IDSUJET"].Visible = false;
                dgvReponse.Columns["IDUSER"].Visible = false;

                dgvReponse.Columns["TEXTREP"].HeaderText = "Texte";
                dgvReponse.Columns["DATEENVOIREP"].HeaderText = "Date d'envoi";


            }
        
        }

        #endregion

        #region Quitter l'application 



    }

    
        #endregion

       
    }

   

