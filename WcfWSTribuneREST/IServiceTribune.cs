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
    /// <summary>
    /// Interface du web service
    /// </summary>
    [ServiceContract]
    public interface IServiceTribune
    {
        #region SUJET


        /// <summary>
        /// Récupère les sujets par id rubrique
        /// </summary>
        /// <param name="idrub"></param>
        /// <returns>Liste Sujet</returns>
        [OperationContract]

        [WebGet(UriTemplate = "Sujet/{idrub}")]
        IList<Sujet> GetSujetByIdRub(string idrub);

       

        #endregion

        #region RUBRIQUE
       
        /// <summary>
        /// Récupère toutes les rubriques
        /// </summary>
        /// <returns>Liste Rubrique</returns>
        [OperationContract]
        
        [WebGet(UriTemplate = "Rubrique")]
        IList<Rubrique> GetRubriques();

        

        #endregion

        #region REPONSE
        
        /// <summary>
        /// Récupère les reponses par Id Sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns>Liste Reponse</returns>
        [OperationContract]
        
        [WebGet(UriTemplate = "Reponse/{idsujet}")]
        IList<Reponse> GetReponsesByIdSujet(string idsujet);

        
        #endregion

       
     
    }
}
