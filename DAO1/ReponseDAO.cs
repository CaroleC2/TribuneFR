﻿using System;
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

        /* ################ TRAVAIL EN COURS ############################*/
        public static int NewReponse(int idUser, int idSujet, string textrep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "NewReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdUser = new SqlParameter("IDUSER", idUser);
            cmd.Parameters.Add(pIdUser);

            SqlParameter pIdSujet = new SqlParameter("IDSUJET", idSujet);
            cmd.Parameters.Add(pIdSujet);

            SqlParameter pTextrep = new SqlParameter("TEXTREP", textrep);
            cmd.Parameters.Add(pTextrep);

            // Ou .......... :
            //cmd.Parameters.Add(new SqlParameter("IDUSER", idUser));
            //cmd.Parameters.Add(new SqlParameter("IDSUJET", idSujet));
            //cmd.Parameters.Add(new SqlParameter("TEXTREP", textrep));


            int nbLigne = cmd.ExecuteNonQuery();
   
        
            return nbLigne;
        }

        
        public static int DeleteReponseById(int idRep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlDataBaseDAO.GetInstance().GetConnection();
            cmd.CommandText = "DeleteReponseById";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pIdRep = new SqlParameter("IDREP", idRep);
            cmd.Parameters.Add(pIdRep);

            int nbLigne = cmd.ExecuteNonQuery();
           
            return nbLigne;
        }


        
    }
}