﻿

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class SqlDataBaseDAO
    {
        //Cette classe est une Singleton : elle est utilisée par toutes les classes DAO 
        //Elle factorise du code d'accès à une base de données SQL SERVER pour créer une connexion, un DataSet
        

        //Singleton
        private static SqlDataBaseDAO _Instance;

        private SqlDataBaseDAO() { }

        public static SqlDataBaseDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new SqlDataBaseDAO();
            return _Instance;
        }

        //Creation d'une OleDbConnection 
        public SqlConnection GetConnection()
        {
            //Tester les Exceptions
           
            SqlConnection cn = new SqlConnection();
            
            cn.ConnectionString = "Data Source=176.31.114.215; Initial Catalog=user10 ;Persist Security Info = true; User Id=user10;Password=026user10 ;Connection Timeout=60";
            
            cn.Open(); //En mode déconnecté, le système ouvre la connexion, si elle n'est pas ouverte 
            return cn;
            

           
        }
        /// <summary>
        /// Creation d'un DataSet à partir d'une requête passée en paramètre
        /// </summary>
        /// <param name="selectCommand"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string selectCommand)
        {
            DataSet objDataSet = new DataSet();
            SqlCommand objCommand = new SqlCommand(selectCommand, GetConnection());
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet);
            return objDataSet;
        }


    }
}
