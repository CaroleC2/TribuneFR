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
    /// Classe d'accès aux entités Réponse
    /// </summary>
    public class ReponseDAO
    {     
        private static ReponseDAO _Instance;

        private SqlDataBaseDAO _Database;

        private ReponseDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }


        /// <summary>
        /// Mise en place du singleton
        /// </summary>
        /// <returns>ReponseDAO</returns>
        public static ReponseDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new ReponseDAO();
            return _Instance;
        }

        /// <summary>
        /// Récupère toutes les réponses
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetReponses()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetReponses";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);


            return objDataSet;
        }

        /// <summary>
        /// Récupère une réponse par Id réponse
        /// </summary>
        /// <param name="idrep"></param>
        /// <returns>Dataset</returns>
        public DataSet GetReponseById(int idrep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetReponseById";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdrep = new SqlParameter("IDREP", idrep);
            cmd.Parameters.Add(pIdrep);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }

        /// <summary>
        /// Récupère une réponse par Id Sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns>Dataset</returns>
        public DataSet GetReponseByIdSujet(int idsujet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetReponseByIdSujet ";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdsujet = new SqlParameter("IDSUJET", idsujet);
            cmd.Parameters.Add(pIdsujet);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }

       /// <summary>
       /// Création d'une réponse
       /// </summary>
       /// <param name="idSujet"></param>
       /// <param name="nomUser"></param>
       /// <param name="textrep"></param>
       /// <param name="dateenvoirep"></param>
       /// <returns></returns>
        public int NewReponse( int idSujet,string nomUser, string textrep, DateTime dateenvoirep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "NewReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdSujet = new SqlParameter("IDSUJET", idSujet);
            cmd.Parameters.Add(pIdSujet);
            
            SqlParameter pNomUser = new SqlParameter("NOMUSER", nomUser);
            cmd.Parameters.Add(pNomUser);

            SqlParameter pTextrep = new SqlParameter("TEXTREP", textrep);
            cmd.Parameters.Add(pTextrep);

            SqlParameter pDateenvoirep = new SqlParameter("DATEENVOIREP", dateenvoirep);
            cmd.Parameters.Add(pDateenvoirep);
            
            int nbLigne = cmd.ExecuteNonQuery();
        
            return nbLigne;
        }

        /// <summary>
        /// Suppression d'une réponse
        /// </summary>
        /// <param name="idRep"></param>
        /// <returns></returns>
        public static int DeleteReponse(int idRep )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "DeleteReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdRep = new SqlParameter("IDREP", idRep);
            cmd.Parameters.Add(pIdRep);
            
            int nbLigne = cmd.ExecuteNonQuery();
           
            return nbLigne;
        }
    }
}