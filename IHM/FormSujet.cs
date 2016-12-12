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
                lbNomRub.Text = rubrique.NomRub;
                lbDate.Text = sujet.DateCreatSujet.ToString();
                utilisateur = new Utilisateur();
                utilisateur = BLLOutils.BLL.ListUtilisateursById(sujet.IdUser);
                txtBoxUser.Text = utilisateur.NomUser;
                txtBoxTitreSujet.Text = sujet.TitreSujet;
                txtBoxTextSujet.Text = sujet.TextSujet;
            }
             
         }

        private void btAjoutSujet_Click(object sender, EventArgs e)
        {
            if (BLLOutils.BLL.NewSujet(rubrique.IdRub, txtBoxUser.Text, txtBoxTitreSujet.Text, txtBoxTextSujet.Text, Convert.ToDateTime(lbDate.Text)) == 1)
            {
                 
                   MessageBox.Show("Validation de l'ajout de votre sujet ");

                this.Close();
            }

            else
            {
                MessageBox.Show("Echec de l'ajout de votre sujet ");
            }
            
            

            

        }

        

        private void btModifSujet_Click(object sender, EventArgs e)
        {
            if (BLLOutils.BLL.UpdateSujet(sujet.IdSujet,txtBoxTitreSujet.Text,sujet.TitreSujet,txtBoxTextSujet.Text, sujet.TextSujet) == 1)
            {
                MessageBox.Show("Validation de la modification de votre sujet ");

                this.Close();
            }

            else
            {
                MessageBox.Show("Echec de la modificaton de votre sujet ");
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

      
    }
}
