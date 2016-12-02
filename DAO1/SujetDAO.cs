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

            // Ou .......... :
            //cmd.Parameters.Add(new SqlParameter("IDUSER", idUser));
            //cmd.Parameters.Add(new SqlParameter("IDSUJET", idSujet));
            //cmd.Parameters.Add(new SqlParameter("TEXTREP", textrep));


            int nbLigne = cmd.ExecuteNonQuery();


            return nbLigne;
        }


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


        public int UpdateSujet(int idRub, string nomUser, string titresujet, string textsujet, DateTime datecreatsujet)
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

            // Ou .......... :
            //cmd.Parameters.Add(new SqlParameter("IDUSER", idUser));
            //cmd.Parameters.Add(new SqlParameter("IDSUJET", idSujet));
            //cmd.Parameters.Add(new SqlParameter("TEXTREP", textrep));


            int nbLigne = cmd.ExecuteNonQuery();


            return nbLigne;
        }



    }
}