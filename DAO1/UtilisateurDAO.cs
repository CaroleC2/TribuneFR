using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metier;

namespace DAO
{
    public class UtilisateurDAO
    {

        //Classe d'accès aux entites Sujet
        //Cette classe utilise les méthodes de la classe AccessDataBaseDAO
        private static UtilisateurDAO _Instance;

        private SqlDataBaseDAO _Database;

        private UtilisateurDAO()
        {
            _Database = SqlDataBaseDAO.GetInstance();
        }
        public static UtilisateurDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new UtilisateurDAO();
            return _Instance;
        }



        public DataSet GetUtilisateurs()
        {

            return _Database.ExecuteDataSet("Select * from UTILISATEUR order by NOMUSER");
        }

        public List<Utilisateur> ListAllUtilisateurs()
        {

            List<Utilisateur> liste = new List<Utilisateur>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from UTILISATEUR order by NOMUSER");
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Utilisateur Utilisateur = new Utilisateur
                                        (
                                        Convert.ToInt32(row["IDUSER"]),
                                        row["NOMUSER"].ToString(),
                                        row["MDPUSER"].ToString(),
                                        Convert.ToInt32(row["DROITUSER"])
                                        );
                liste.Add(Utilisateur);
            }


            return liste;
        }

        public List<Utilisateur> ListUtilisateursById(int IdUser)
        {

            List<Utilisateur> liste = new List<Utilisateur>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from RUBRIQUE WHERE IDUSER=" + IdUser);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Utilisateur Utilisateur = new Utilisateur
                                                (
                                                Convert.ToInt32(row["IDUSER"]),
                                                row["NOMUSER"].ToString(),
                                                row["MDPUSER"].ToString(),
                                                Convert.ToInt32(row["DROITUSER"])
                                                );
                liste.Add(Utilisateur);
            }

            return liste;
        }

        public List<Utilisateur> ListUtilisateursByNom(string NomUser)
        {

            List<Utilisateur> liste = new List<Utilisateur>();
            DataSet objDataSet = _Database.ExecuteDataSet("Select * from RUBRIQUE WHERE NOMUSER=" + NomUser);
            foreach (DataRow row in objDataSet.Tables[0].Select())
            {
                Utilisateur Utilisateur = new Utilisateur
                                                (
                                                Convert.ToInt32(row["IDUSER"]),
                                                row["NOMUSER"].ToString(),
                                                row["MDPUSER"].ToString(),
                                                Convert.ToInt32(row["DROITUSER"])
                                                );
                liste.Add(Utilisateur);
            }

            return liste;
        }
    }
}
