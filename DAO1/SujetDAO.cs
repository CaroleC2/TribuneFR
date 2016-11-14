using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metier;

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

        //Méthodes qui retournent DataSet
        //public DataSet GetAllSujets()
        //{

        //    return _Database.ExecuteDataSet("Select * from SUJET order by IDSUJET");
        //}

        //public DataSet GetSujetsById(int idsujet)
        //{
        //    SqlDataBaseDAO database = SqlDataBaseDAO.GetInstance();
        //    return _Database.ExecuteDataSet("Select * from SUJET where IDSUJET = " + idsujet);

        //}
        
        public DataSet GetSujets()
        {

            return _Database.ExecuteDataSet("Select * from SUJET order by TitreSujet");
        }

        public DataSet GetSujetsByIdRub(string idrub)
        {
            SqlDataBaseDAO database = SqlDataBaseDAO.GetInstance();
            return _Database.ExecuteDataSet("Select * from SUJET where IDRUB= " + idrub);
        }

        public List<Sujet> ListAllSujets()
        {

            List<Sujet> liste = new List<Sujet>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from SUJET order by TitreSujet");
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Sujet Sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDRUB"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TITRESUJET"].ToString(),
                                        row["TEXTSUJET"].ToString(),
                                        Convert.ToDateTime(row["DATECREATSUJET"])
                                        );
                liste.Add(Sujet);
            }

               
            return liste;
        }

        public List<Sujet> ListSujetsByTitreSujet(string TitreSujet)
        {

            List<Sujet> liste = new List<Sujet>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from SUJET WHERE TITRESUJET=" + TitreSujet);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Sujet Sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDRUB"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TITRESUJET"].ToString(),
                                        row["TEXTSUJET"].ToString(),
                                        Convert.ToDateTime(row["DATECREATSUJET"])
                                        );
                liste.Add(Sujet);
            }


            return liste;
        }

        public List<Sujet> ListSujetsByIdRub(string IdRub)
        {

            List<Sujet> liste = new List<Sujet>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from SUJET WHERE IDRUB=" + IdRub);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Sujet Sujet = new Sujet(Convert.ToInt32(row["IDSUJET"]),
                                        Convert.ToInt32(row["IDRUB"]),
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["TITRESUJET"].ToString(),
                                        row["TEXTSUJET"].ToString(),
                                        Convert.ToDateTime(row["DATECREATSUJET"])
                                        );
                liste.Add(Sujet);
            }


            return liste;
        }
    }
}
