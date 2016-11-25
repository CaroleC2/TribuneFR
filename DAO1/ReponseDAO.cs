using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class ReponseDAO
    {

        //Classe d'accès aux entites Sujet
        //Cette classe utilise les méthodes de la classe AccessDataBaseDAO
        private static ReponseDAO _Instance;

        private SqlDataBaseDAO _Database;

        private ReponseDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }
        public static ReponseDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new ReponseDAO();
            return _Instance;
        }

        
        


        

       

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









        //public List<Reponse> ListAllReponses()
        //{

        //    List<Reponse> liste = new List<Reponse>();
        //    DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE order by IDREP");
        //    foreach (DataRow row in objDataSet.Tables[0].Select())
        //    {
        //        Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
        //                                Convert.ToInt32(row["IDSUJET"]),
        //                                Convert.ToInt32(row["IDUSER"]),
        //                                row["TEXTREP"].ToString(),
        //                                Convert.ToDateTime(row["DATEENVOIREP"])
        //                                );
        //        liste.Add(reponse);
        //    }


        //    return liste;
        //}

        //public List<Reponse> ListReponsesById(int idrep)
        //{

        //    List<Reponse> liste = new List<Reponse>();
        //    DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE WHERE IDREP=" + idrep);
        //    foreach (DataRow row in objDataSet.Tables[0].Select())
        //    {
        //        Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
        //                                Convert.ToInt32(row["IDSUJET"]),
        //                                Convert.ToInt32(row["IDUSER"]),
        //                                row["TEXTREP"].ToString(),
        //                                Convert.ToDateTime(row["DATEENVOIREP"])
        //                                );
        //        liste.Add(reponse);
        //    }

        //    return liste;
        //}

        //public List<Reponse> ListReponsesByIdSujet(int idsujet)
        //{

        //    List<Reponse> liste = new List<Reponse>();
        //    DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE WHERE IDSUJET=" + idsujet);
        //    foreach (DataRow row in objDataSet.Tables[0].Select())
        //    {
        //        Reponse reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
        //                                Convert.ToInt32(row["IDSUJET"]),
        //                                Convert.ToInt32(row["IDUSER"]),
        //                                row["TEXTREP"].ToString(),
        //                                Convert.ToDateTime(row["DATEENVOIREP"])
        //                                );
        //        liste.Add(reponse);
        //    }

        //    return liste;
        //}
    }
}