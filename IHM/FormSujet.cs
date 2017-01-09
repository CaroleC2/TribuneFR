using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TribuneDevMETIER;

namespace IHM
{
    public partial class FormSujet : Form
    {
        internal Rubrique rubrique;
        internal Sujet sujet;
        internal Utilisateur utilisateur;
        internal bool modif = false;

        public FormSujet()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            lbDate.Text = now.ToString();
        }

         private void FormSujet_Load(object sender, EventArgs e)
         {
             if (modif)
             {
                btAjoutSujet.Visible = false;

                lbDate.Text = sujet.DateCreatSujet.ToString();
                utilisateur = new Utilisateur();
                utilisateur = BLLOutils.BLL.ListUtilisateursById(sujet.IdUser);
                txtBoxUser.Text = utilisateur.NomUser;
                txtBoxTitreSujet.Text = sujet.TitreSujet;
                txtBoxTextSujet.Text = sujet.TextSujet;
            }
            else
            {
                GestionGrisage();
                btModifSujet.Visible = false;
            }
        }

        private void btAjoutSujet_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxTextSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxTitreSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                btAjoutSujet.Enabled = true;

                if (BLLOutils.BLL.NewSujet(rubrique.IdRub, txtBoxUser.Text, txtBoxTitreSujet.Text, txtBoxTextSujet.Text, Convert.ToDateTime(lbDate.Text)) == 1)
                {

                    MessageBox.Show("Validation de l'ajout de votre sujet ", "Valider Ajout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Echec de l'ajout de votre sujet ", "Erreur Ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }
        
        private void btModifSujet_Click(object sender, EventArgs e)
        {
            if (BLLOutils.BLL.UpdateSujet(sujet.IdSujet,txtBoxTitreSujet.Text,sujet.TitreSujet,txtBoxTextSujet.Text, sujet.TextSujet) == 1)
            {
                MessageBox.Show("Validation de la modification de votre sujet ","Valider Modification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                this.Close();
            }

            else
            {
                MessageBox.Show("Echec de la modificaton de votre sujet ","Erreur Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez-vous annuler l'opération en cours ?", "Annuler l'opération", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
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

       

        private void GestionGrisage()
        {
            btAjoutSujet.Enabled = !String.IsNullOrWhiteSpace(txtBoxTextSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxTitreSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxUser.Text);
            btAnnuler.Enabled = true;

           // btModifSujet.Enabled = !String.IsNullOrWhiteSpace(txtBoxTextSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxTitreSujet.Text) && !String.IsNullOrWhiteSpace(txtBoxUser.Text);
           

        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {
            GestionGrisage();
        }

        private void txtBoxTitreSujet_TextChanged(object sender, EventArgs e)
        {
            GestionGrisage();
        }

        private void txtBoxTextSujet_TextChanged(object sender, EventArgs e)
        {
            GestionGrisage();
        }
    }
}
