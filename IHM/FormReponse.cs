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



        public FormReponse()
        {
            InitializeComponent();
        }

        private void FormModifReponse_Load(object sender, EventArgs e)
        {
            //Utilise des methodes d'accès qui renvoient un Dataset 
            //bindingSourceRub.DataSource = objRubDAO.GetRubriques().Tables[0];


           

        }

        private void btAjoutRep_Click(object sender, EventArgs e)
        {


            BLLOutils.BLL.NewReponse(sujet.IdSujet, txtBoxRep.Text);
            
        


    }

    //private void comboBoxRub_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //if (comboBoxRub.SelectedValue != null)
    //    //{
    //    //    //Utilise des methodes d'accès qui renvoient un Dataset 
    //    //    bindingSourceRep.DataSource = BLL.ListRubriquesById(int.Parse(comboBoxRub.SelectedValue.ToString()));
    //    //    bindingSourceRep.DataSource = BLL.ListSujetsByIdRub(int.Parse(comboBoxRub.SelectedValue.ToString()));

    //    //    dgvRep.DataSource = bindingSourceRep;
    //    //    dgvRep.Columns["IDREP"].Visible = false;
    //    //    dgvRep.Columns["IDUSER"].Visible = false;
    //    //    dgvRep.Columns["IDSUJET"].Visible = false;

    //    //    dgvRep.Columns["TEXTREP"].HeaderText = "Texte";
    //    //    dgvRep.Columns["DATEENVOICREAT"].HeaderText = "Date d'envoi";


    //    }


    //private void dgvRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
    //{

    //}
}
}

