using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SujetDAO
    {
        
        //Classe d'accès aux entites Sujet
        //Cette classe utilise les méthodes de la classe AccessDataBaseDAO
        private static SujetDAO _Instance;

        private SqlDataBaseDAO _Database;

        private SujetDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }
        public static SujetDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new SujetDAO();
            return _Instance;
        }

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


       
       
    }
}