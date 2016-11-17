using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfWSTribune
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceForum
    {
        #region SUJET
        [OperationContract]
        Sujet GetSujet(int idsujet);

        [OperationContract]
        IList<Sujet> GetSujets();

        [OperationContract]
        IList<Sujet> GetSujetsById(int idsujet);

        [OperationContract]
        DataSet FillSujetByIdSujet(int idsujet);

        [OperationContract]
        DataSet FillSujetByIdRub(int idrub);

        #endregion

        #region RUBRIQUE
        [OperationContract]
        Rubrique GetRubrique(int idrub);

        [OperationContract]
        IList<Rubrique> GetRubriques();

        [OperationContract]
        IList<Rubrique> GetRubriquesById(int idrub);

        [OperationContract]
        DataSet FillRubriqueByIdRub(int idrub);


        #endregion

        #region REPONSE
        [OperationContract]
        Reponse GetReponse(int idrep);

        [OperationContract]
        IList<Reponse> GetReponses();

        [OperationContract]
        IList<Sujet> GetReponsesById(int idrep);

        [OperationContract]
        IList<Sujet> GetReponsesByIdSujet(int idsujet);

        [OperationContract]
        DataSet FillReponseById(int idrep);

        [OperationContract]
        DataSet FillReponseByIdSujet(int idsujet);

        #endregion

        #region UTILISATEUR
        [OperationContract]
        Utilisateur GetUtilisateur(int iduser);

        [OperationContract]
        IList<Utilisateur> GetUtilisateurs();

        [OperationContract]
        IList<Utilisateur> GetUtilisateursById(int iduser);

        [OperationContract]
        DataSet FillUtilisateurByIdUser(int iduser);

        #endregion

        [OperationContract]
        void Disconnect();





    }
}
