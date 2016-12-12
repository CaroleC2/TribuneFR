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
   
    public class ServiceTribune : IServiceTribune
    {


        #region SUJET


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

        public IList<Rubrique> GetRubriques()
        {
            return BLL.ListAllRubriques();
        }

        #endregion

        #region REPONSE
        

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

