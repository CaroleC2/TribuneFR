
using Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfWSTribuneREST

 
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceTribune
    {
        #region SUJET
  
       // /// <summary>
       // /// Renvoi tous les sujets
       // /// </summary>
       // /// <returns></returns>
       // [OperationContract]
       //// [WebGet(UriTemplate = "Sujets", ResponseFormat = WebMessageFormat.Json)]
       // [WebGet(UriTemplate = "Sujet")]
       // IList<Sujet> GetSujets();

        /// <summary>
        /// Renvoi les sujets par id rubrique
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        [OperationContract]
       // [WebGet(UriTemplate = "Sujet?idsujet={idsujet}", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Sujet/{idrub}")]
        IList<Sujet> GetSujetByIdRub(string idrub);

       

        #endregion

        #region RUBRIQUE
       

        [OperationContract]
        //[WebGet(UriTemplate = "Rubriques", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Rubrique")]
        IList<Rubrique> GetRubriques();

        //[OperationContract]
        ////[WebGet(UriTemplate = "Rubrique?idrub={idrub}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Rubrique/{idrub}")]
        //IList<Rubrique> GetRubriquesById(string idrub);

        
        


        #endregion

        #region REPONSE
        //[OperationContract]
        ////[WebGet(UriTemplate = "Reponse/{idrep}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse/{idrep}")]
        //Reponse GetReponse(int idrep);

        //[OperationContract]
        ////[WebGet(UriTemplate = "Reponses", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse")]
        //IList<Reponse> GetReponses();

        //[OperationContract]
        ////[WebGet(UriTemplate = "Reponse?idrep={idrep}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse?idrep={idrep}")]
        //IList<Reponse> GetReponsesById(string idrep);

        [OperationContract]
        // [WebGet(UriTemplate = "Reponse/{idsujet}", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Reponse/{idsujet}")]
        IList<Reponse> GetReponsesByIdSujet(string idsujet);

        
       

        #endregion

        #region UTILISATEUR
        ////[OperationContract]
        //////[WebGet(UriTemplate = "Utilisateur/{iduser}", ResponseFormat = WebMessageFormat.Json)]
        ////[WebGet(UriTemplate = "Utilisateur/{iduser}")]
        ////Utilisateur GetUtilisateur(int iduser);

        //[OperationContract]
        ////[WebGet(UriTemplate = "Utilisateurs", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Utilisateur")]
        //IList<Utilisateur> GetUtilisateurs();

        //[OperationContract]
        //[WebGet(UriTemplate = "Utilisateur/{iduser}", ResponseFormat = WebMessageFormat.Json)]
        ////[WebGet(UriTemplate = "Utilisateur /{iduser}"")]
        //IList<Utilisateur> GetUtilisateursById(string iduser);

     
       

        #endregion

        //[OperationContract]
        //void Disconnect();


     
    }
}
