

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TribuneDevMETIER;

namespace WcfWSTribuneREST

 
{

    [ServiceContract]
    public interface IServiceTribune
    {
        #region SUJET


        /// <summary>
        /// Renvoi les sujets par id rubrique
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        [OperationContract]

        [WebGet(UriTemplate = "Sujet/{idrub}")]
        IList<Sujet> GetSujetByIdRub(string idrub);

       

        #endregion

        #region RUBRIQUE
       

        [OperationContract]
      
        [WebGet(UriTemplate = "Rubrique")]
        IList<Rubrique> GetRubriques();

        

        #endregion

        #region REPONSE
        

        [OperationContract]
        
        [WebGet(UriTemplate = "Reponse/{idsujet}")]
        IList<Reponse> GetReponsesByIdSujet(string idsujet);

        
        #endregion

       
     
    }
}
