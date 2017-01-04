using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
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
}


        //#region Propriété

        //private static SqlConnection cn = SqlDataBaseDAO.GetConnection();

        //#endregion

        

        //#region Méthodes

        //public static List<Rubrique> GetAllRubriques()
        //{
           
        //    SqlCommand cmd = cn.CreateCommand();
        //    cmd.CommandText = "GetAllRubriques";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable datatable = new DataTable("Rubrique");
        //    adapter.Fill(datatable);
            

        //    if (datatable.Rows.Count >= 1)
        //    {
        //        List<Rubrique> ListeRubriques = new List<Rubrique>();
        //        foreach (DataRow row in datatable.Rows)
        //        {
        //            Rubrique rubrique = new Rubrique();
        //            rubrique.IdRub = (int)row["IDRUB"];
        //            rubrique.NomRub = row["NOMRUB"].ToString();
        //            rubrique.TextRub = row["TEXTRUB"].ToString();
        //            ListeRubriques.Add(rubrique);
        //        }
        //        return ListeRubriques;
        //    }
        //    return null;
        //}

       

        //public static Rubrique GetRubriqueById(int idrub)
        //{
        
        //    SqlCommand cmd = cn.CreateCommand();
        //    cmd.CommandText = "GetRubriqueById";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlParameter param = cmd.CreateParameter();
        //    param.ParameterName = "@IDRUB";
        //    param.Value = idrub;
        //    cmd.Parameters.Add(param);
        //    Rubrique rubrique;
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable datatable = new DataTable("Rubriques");
        //    adapter.Fill(datatable);
            

        //    if (datatable.Rows.Count == 1)
        //    {

        //        DataRow row = datatable.Rows[0]; //On obtient la ligne à l'index specifié, ici 0 c'est la 1ère ligne
        //        rubrique = new Rubrique(idrub, row["NOMRUB"].ToString(), row["TEXTRUB"].ToString());
        //        return rubrique;
        //    }
        //    return null;

        //}

        //#endregion

    