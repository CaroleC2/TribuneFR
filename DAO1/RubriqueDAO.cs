using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metier;

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

            return _Database.ExecuteDataSet("Select * from RUBRIQUE ");
        }

        public DataSet GetRubriquesByIdRub(string idrub)
        { 
            SqlDataBaseDAO database = SqlDataBaseDAO.GetInstance();
               return _Database.ExecuteDataSet("Select * from RUBRIQUE where IDRUB=" + idrub);
        }

        public List<Rubrique> ListAllRubriques()
        {

            List<Rubrique> liste = new List<Rubrique>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from RUBRIQUE");
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Rubrique Rubrique = new Rubrique
                                        (
                                        Convert.ToInt32(row["IDRUB"]),
                                        row["NOMRUB"].ToString(),
                                        row["TEXTRUB"].ToString()
                                        );
                liste.Add(Rubrique);
            }


            return liste;
        }

        public List<Rubrique> ListRubriquesById(int IdRub)
        {

            List<Rubrique> liste = new List<Rubrique>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from RUBRIQUE WHERE IDRUB=" + IdRub);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Rubrique Rubrique = new Rubrique
                                                (
                                                Convert.ToInt32(row["IDRUB"]),
                                                row["NOMRUB"].ToString(),
                                                row["TEXTRUB"].ToString()
                                                );
                liste.Add(Rubrique);
            }


            return liste;
        }


    }
}
