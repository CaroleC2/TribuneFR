using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWebService
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
        DataSet FillReponseByIdReponse(int idrep);

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

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "WcfWebService.ContractType".
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
