using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BLL
    {

        #region SUJET

        public List<Sujet> ListAllSujets()
        {
            return SujetDAO.GetInstance().ListAllSujets();
            
        }

        public List<Sujet> ListSujetsByTitreSujet(string titresujet)
        {
            return SujetDAO.GetInstance().ListSujetsByTitreSujet(titresujet);
           
        }

        public List<Sujet> ListSujetsByIdRub(string idrub)
        {
            return SujetDAO.GetInstance().ListSujetsByIdRub(idrub);

        }


        #endregion

        #region RUBRIQUE



        public List<Rubrique> ListAllRubriques()
        {
            return RubriqueDAO.GetInstance().ListAllRubriques();

        }

        public List<Rubrique> ListRubriquesByNomRub(int idrub)
        {
            return RubriqueDAO.GetInstance().ListRubriquesById(idrub);

        }

        #endregion

        #region REPONSE

        public List<Reponse> ListAllReponses()
        {
            return ReponseDAO.GetInstance().ListAllReponses();

        }

        public List<Reponse> ListReponsesById(int idrep)
        {
            return ReponseDAO.GetInstance().ListReponsesById(idrep);

        }

        public List<Reponse> ListReponsesByIdSujet(int idsujet)
        {
            return ReponseDAO.GetInstance().ListReponsesByIdSujet(idsujet);

        }

        #endregion

        #region USER

        public List<Utilisateur> ListAllUtilisateurs()
        {
            return UtilisateurDAO.GetInstance().ListAllUtilisateurs();

        }

        public List<Utilisateur> ListUtilisateursById(int iduser)
        {
            return UtilisateurDAO.GetInstance().ListUtilisateursById(iduser);

        }

        public List<Utilisateur> ListUtilisateursByNom(string nomuser)
        {
            return UtilisateurDAO.GetInstance().ListUtilisateursByNom(nomuser);

        }

        #endregion

    }
}
