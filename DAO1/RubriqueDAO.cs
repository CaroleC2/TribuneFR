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
    /// Classe d'accès aux entites Rubrique
    /// </summary>
    public class RubriqueDAO
    {
        private static RubriqueDAO _Instance;

        private SqlDataBaseDAO _Database;

        private RubriqueDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }

        /// <summary>
        /// Mise en place du singleton
        /// </summary>
        /// <returns>RubriqueDAO</returns>
        public static RubriqueDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new RubriqueDAO();
            return _Instance;
        }
        
        /// <summary>
        /// Récupère toutes les rubriques 
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetRubriques()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetRubriques";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);


            return objDataSet;
        }

        /// <summary>
        /// Récupère la rubrique par Nom Rubrique
        /// </summary>
        /// <param name="nomrub"></param>
        /// <returns>Dataset</returns>
        public DataSet GetRubriqueByNomRub(string nomrub)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetRubriqueByNomRub";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pNomrub = new SqlParameter("NOMRUB", nomrub);
            cmd.Parameters.Add(pNomrub);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }
        /// <summary>
        /// Récupère la rubrique par Id Rubrique
        /// </summary>
        /// <param name="idrub"></param>
        /// <returns>Dataset</returns>
        public DataSet GetRubriqueByIdRub(int idrub)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetRubriqueById ";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pDeptno = new SqlParameter("IDRUB", idrub);
            cmd.Parameters.Add(pDeptno);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }
     
    }
}


     

    