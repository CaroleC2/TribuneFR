using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class UtilisateurDAO
    {

        //Classe d'accès aux entites Sujet
        //Cette classe utilise les méthodes de la classe AccessDataBaseDAO
        private static UtilisateurDAO _Instance;

        private SqlDataBaseDAO _Database;

        private UtilisateurDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }
        public static UtilisateurDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new UtilisateurDAO();
            return _Instance;
        }



        public DataSet GetUtilisateurs()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetUtilisateurs";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);


            return objDataSet;
        }

        public DataSet GetUtilisateurByNom(string nomuser)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetUtilisateurByNom";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pNomuser = new SqlParameter("NOMUSER", nomuser);
            cmd.Parameters.Add(pNomuser);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }

        public DataSet GetUtilisateurById(int iduser)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "GetUtilisateurById ";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIduser = new SqlParameter("IDUSER", iduser);
            cmd.Parameters.Add(pIduser);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(cmd);
            DataSet objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);

            return objDataSet;
        }

       
    }
}