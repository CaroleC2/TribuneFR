using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metier;

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

            return _Database.ExecuteDataSet("Select * from REPONSE order by IDREP");
        }

        public List<Reponse> ListAllReponses()
        {

            List<Reponse> liste = new List<Reponse>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE order by IDREP");
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Reponse Reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
                                        Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TEXTREP"].ToString(),
                                        Convert.ToDateTime(row["DATEENVOIREP"])
                                        );
                liste.Add(Reponse);
            }


            return liste;
        }

        public List<Reponse> ListReponsesById(int IdRep)
        {

            List<Reponse> liste = new List<Reponse>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE WHERE IDREP=" + IdRep);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Reponse Reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
                                        Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TEXTREP"].ToString(),
                                        Convert.ToDateTime(row["DATEENVOIREP"])
                                        );
                liste.Add(Reponse);
            }
            
            return liste;
        }

        public List<Reponse> ListReponsesByIdSujet(int IdSujet)
        {

            List<Reponse> liste = new List<Reponse>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from REPONSE WHERE IDSUJET=" + IdSujet);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Reponse Reponse = new Reponse(Convert.ToInt32(row["IDREP"]),
                                        Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TEXTREP"].ToString(),
                                        Convert.ToDateTime(row["DATEENVOIREP"])
                                        );
                liste.Add(Reponse);
            }

            return liste;
        }
    }
}
