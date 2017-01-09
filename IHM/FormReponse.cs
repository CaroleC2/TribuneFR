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
    public partial class FormReponse : Form
    {
        internal Sujet sujet;

        internal Reponse reponse;

        internal Utilisateur utilisateur;

        public FormReponse()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            lbDate.Text = now.ToString();
           
        }

        private void FormReponse_Load(object sender, EventArgs e)
        {
            //Utilise des methodes d'accès qui renvoient un Dataset 
            //bindingSourceRub.DataSource = objRubDAO.GetRubriques().Tables[0];
            txtBoxSujet.Text = sujet.TitreSujet;
            GestionGrisage();
        }

        private void btAjoutRep_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoxRep.Text) && !String.IsNullOrWhiteSpace(txtBoxUser.Text))
            {
                btAjoutRep.Enabled = true;

                //string idSujet = lbSujet.Text;
                //string NomUser = lbUser.Text;
                //string textRep = txtBoxRep.Text;
                //string now = lbDate.Text;

                //BLLOutils.BLL.NewReponse(int.Parse(lbSujet.Text), lbUser.Text,txtBoxRep.Text, Convert.ToDateTime(lbDate.Text));

                if (BLLOutils.BLL.NewReponse(sujet.IdSujet, txtBoxUser.Text, txtBoxRep.Text, Convert.ToDateTime(lbDate.Text)) == 1)
                {

                    MessageBox.Show("Validation de l'ajout de votre réponse ");

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Echec de l'ajout de votre réponse ");
                }
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

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {
            GestionGrisage();
        }

        private void txtBoxRep_TextChanged(object sender, EventArgs e)
        {
            GestionGrisage();
        }

        private void GestionGrisage()
        {
            btAjoutRep.Enabled = !String.IsNullOrWhiteSpace(txtBoxRep.Text) && !String.IsNullOrWhiteSpace(txtBoxUser.Text);
            btAnnuler.Enabled = true;
            
        }
    }
}

