using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace IHM
{
    public partial class FormSujet : Form
    {
        internal Rubrique rubrique;
        internal Sujet sujet;
        

        public FormSujet()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            lbDate.Text = now.ToString();
        }

         private void FormSujet_Load(object sender, EventArgs e)
         {
            
            lbNomRub.Text = rubrique.NomRub;
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
