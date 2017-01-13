using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// Classe d'accès aux entités Sujet
    /// </summary>
    public class SujetDAO
    {   
        private static SujetDAO _Instance;

        private SqlDataBaseDAO _Database;

        private SujetDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }

        /// <summary>
        /// /// Mise en place du singleton
        /// </summary>
        /// <returns>SujetDAO</returns>
        public static SujetDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new SujetDAO();
            return _Instance;
        }
        /// <summary>
        /// Récupère tous les sujets
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetSujets()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetSujets";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);


            return objDataSet;
        }

        /// <summary>
        /// Récupère  un sujet par Id Rubrique
        /// </summary>
        /// <param name="idrub"></param>
        /// <returns>Dataset</returns>
        public DataSet GetSujetByIdRub(int idrub)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetSujetByIdRub";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdrub = new SqlParameter("IDRUB", idrub);
            cmd.Parameters.Add(pIdrub);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);


            return objDataSet;
        }

        /// <summary>
        /// Création d'un nouveau sujet
        /// </summary>
        /// <param name="idRub"></param>
        /// <param name="nomUser"></param>
        /// <param name="titresujet"></param>
        /// <param name="textsujet"></param>
        /// <param name="datecreatsujet"></param>
        /// <returns></returns>
        public int NewSujet( int idRub, string nomUser,string titresujet, string textsujet, DateTime datecreatsujet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "NewSujet";
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlParameter pIdRub = new SqlParameter("IDRUB", idRub);
            cmd.Parameters.Add(pIdRub);

            SqlParameter pNomUser = new SqlParameter("NOMUSER", nomUser);
            cmd.Parameters.Add(pNomUser);

            SqlParameter pTitresujet = new SqlParameter("TITRESUJET", titresujet);
            cmd.Parameters.Add(pTitresujet);

            SqlParameter pTextsujet = new SqlParameter("TEXTSUJET", textsujet);
            cmd.Parameters.Add(pTextsujet);

            SqlParameter pDatecreatsujet = new SqlParameter("DATECREATSUJET", datecreatsujet);
            cmd.Parameters.Add(pDatecreatsujet);

            int nbLigne = cmd.ExecuteNonQuery();

            return nbLigne;
        }

        /// <summary>
        /// Suppression d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static int DeleteSujet(int idSujet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdSujet = new SqlParameter("IDSUJET", idSujet);
            cmd.Parameters.Add(pIdSujet);

            int nbLigne = cmd.ExecuteNonQuery();

            return nbLigne;
        }

        /// <summary>
        /// Modification d'un sujet
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="titresujet"></param>
        /// <param name="ancientitre"></param>
        /// <param name="textsujet"></param>
        /// <param name="ancientext"></param>
        /// <returns></returns>
        public int UpdateSujet(int idSujet,  string titresujet,string ancientitre, string textsujet, string ancientext)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "UpdateSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pISujet = new SqlParameter("IDSUJET", idSujet);
            cmd.Parameters.Add(pISujet);

            SqlParameter pTitresujet = new SqlParameter("TITRESUJET", titresujet);
            cmd.Parameters.Add(pTitresujet);

            SqlParameter pAncienTitre = new SqlParameter("ANCIENTITRE", ancientitre);
            cmd.Parameters.Add(pAncienTitre);

            SqlParameter pTextsujet = new SqlParameter("TEXTSUJET", textsujet);
            cmd.Parameters.Add(pTextsujet);

            SqlParameter pAncienText = new SqlParameter("ANCIENTEXT", ancientext);
            cmd.Parameters.Add(pAncienText);
                       
            int nbLigne = cmd.ExecuteNonQuery();
            
            return nbLigne;
        }      
    }
}