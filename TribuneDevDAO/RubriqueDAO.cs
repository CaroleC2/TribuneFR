using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TribuneDevDAO
{
    public class RubriqueDAO
    {
        //Classe d'accès aux entites Sujet
        //Cette classe utilise les méthodes de la classe AccessDataBaseDAO
        private static RubriqueDAO _Instance;

        private SqlDataBaseDAO _Database;

        private RubriqueDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }
        public static RubriqueDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new RubriqueDAO();
            return _Instance;
        }



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
