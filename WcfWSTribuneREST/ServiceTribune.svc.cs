using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Web.Configuration;
using TribuneDevMETIER;
using BLLOutils;

namespace WcfWSTribuneREST
{
   /// <summary>
   /// Classe Service Tribune
   /// </summary>
    public class ServiceTribune : IServiceTribune
    {
        
        #region SUJET

        /// <summary>
        /// Renvoie les réponses par id sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns>List Reponse</returns>
        public IList<Reponse> GetReponsesByIdSujet(string idsujet)
        {
            int r;
            if (int.TryParse(idsujet, out r))
            {
                return BLL.ListReponsesByIdSujet(r);
            }

            else
            {
                return null;
            }
        }
        

        #endregion
        
        #region RUBRIQUE
        /// <summary>
        /// Renvoie toutes les rubriques
        /// </summary>
        /// <returns></returns>
        public IList<Rubrique> GetRubriques()
        {
            return BLL.ListAllRubriques();
        }

        #endregion

        #region REPONSE
        
        /// <summary>
        /// Renvoie les sujets par id rubrique
        /// </summary>
        /// <param name="idrub"></param>
        /// <returns></returns>
        public IList<Sujet> GetSujetByIdRub(string idrub)
        {
            int r;
            if (int.TryParse(idrub, out r))
            {
                return BLL.ListSujetsByIdRub(r);
            }

            else
            {
                return null;
            }
        }

        #endregion


    }
}

