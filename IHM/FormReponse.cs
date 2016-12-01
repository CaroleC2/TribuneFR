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


           

        }

        private void btAjoutRep_Click(object sender, EventArgs e)
        {

            //Test ajout d'un réponse

            string idSujet = lbSujet.Text;
            string NomUser = lbUser.Text;
            string textRep = txtBoxRep.Text;
            string now = lbDate.Text;

            BLLOutils.BLL.NewReponse(lbSujet.Text, lbUser.Text,txtBoxRep.Text, lbDate.Text);


            //BLLOutils.BLL.NewReponse(utilisateur.idUser, sujet.IdSujet, txtBoxRep.Text);
          
        }

       
    }
}

