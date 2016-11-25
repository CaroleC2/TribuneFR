
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

    // Flux de syndication
        //[ServiceContract]
        //public interface IServiceRSS
        //{
        //    [OperationContract]
        //    [WebGet(UriTemplate = "Rss")]
        //    Rss20FeedFormatter GetRSS();
        //}

{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceTribune
    {
        #region SUJET
  
        /// <summary>
        /// Renvoi tous les sujets
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "Sujets", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Sujet")]
        IList<Sujet> GetSujets();

        /// <summary>
        /// Renvoi les sujets par id sujet
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "Sujet?idsujet={idsujet}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Sujet/{idsujet}")]
        IList<Sujet> GetSujetsById(string idsujet);

       

        #endregion

        #region RUBRIQUE
        //[OperationContract]
        ////[WebGet(UriTemplate = "Rubrique?idrub={idrub}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Rubrique/{idrub}")]
        //Rubrique GetRubrique(string idrub);

        [OperationContract]
        //[WebGet(UriTemplate = "Rubriques", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Rubrique")]
        IList<Rubrique> GetRubriques();

        [OperationContract]
        [WebGet(UriTemplate = "Rubrique?idrub={idrub}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Rubrique/{idrub}")]
        IList<Rubrique> GetRubriquesById(string idrub);

        
        DataSet FillRubriqueByIdRub(int idrub);


        #endregion

        #region REPONSE
        //[OperationContract]
        ////[WebGet(UriTemplate = "Reponse/{idrep}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse/{idrep}")]
        //Reponse GetReponse(int idrep);

        [OperationContract]
        //[WebGet(UriTemplate = "Reponses", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Reponse")]
        IList<Reponse> GetReponses();

        [OperationContract]
        [WebGet(UriTemplate = "Reponse?idrep={idrep}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse?idrep={idrep}")]
        IList<Reponse> GetReponsesById(string idrep);

        
        [WebGet(UriTemplate = "Reponse/{idsujet}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Reponse/{idsujet}")]
        IList<Reponse> GetReponsesByIdSujet(string idsujet);

        
        DataSet FillReponseById(int idrep);

      
        DataSet FillReponseByIdSujet(int idsujet);

        #endregion

        #region UTILISATEUR
        //[OperationContract]
        ////[WebGet(UriTemplate = "Utilisateur/{iduser}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Utilisateur/{iduser}")]
        //Utilisateur GetUtilisateur(int iduser);

        [OperationContract]
        //[WebGet(UriTemplate = "Utilisateurs", ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "Utilisateur")]
        IList<Utilisateur> GetUtilisateurs();

        [OperationContract]
        [WebGet(UriTemplate = "Utilisateur/{iduser}", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(UriTemplate = "Utilisateur /{iduser}"")]
        IList<Utilisateur> GetUtilisateursById(string iduser);

     
        DataSet FillUtilisateurById(int iduser);

        #endregion

        [OperationContract]
        void Disconnect();


        //public class ServiceRSS : IServiceRSS
        //{
        //    public Rss20FeedFormatter GetRSS()
        //    {
        //        SyndicationFeed feed = new SyndicationFeed(
        //                               "Test Flux RSS",
        //                               "Test",
        //                               new Uri("http://www.2isa.com"),
        //                               "TestChannelID",
        //                               DateTime.Now);
        //        List<SyndicationItem> items = new List<SyndicationItem>();
        //        feed.Items = items;

        //        SyndicationItem item1 = new SyndicationItem(
        //                                "Parrainage CDI",
        //                                "lancement du parrainage des CDI05",
        //                                new Uri("http://www.2isa.com/2isa/actualites/parrainage"),
        //                                "1",
        //                                 DateTime.Now);
        //        item1.Categories.Add(new SyndicationCategory("Actus"));
        //        items.Add(item1);
        //        SyndicationItem item2 = new SyndicationItem(
        //                                     "Job dating",
        //                                     "Job dating à Toulouse",
        //                                     new Uri("http://www.2isa.com/2isa/actualites/jobdating"),
        //                                     "2",
        //                                     DateTime.Now);
        //        item2.Categories.Add(new SyndicationCategory("Actus"));
        //        items.Add(item2);

        //        SyndicationItem item3 = new SyndicationItem(
        //                                "Nouveau cursus DL",
        //                                "Formation Développeur Logiciel",
        //                                new Uri(" http://www.2isa.com/2isa/formations/dl"),
        //                                "3",
        //                                DateTime.Now);
        //        item3.Categories.Add(new SyndicationCategory("Formations"));
        //        items.Add(item3);

        //        Rss20FeedFormatter rssFormatter = new Rss20FeedFormatter(feed, false);
        //        return rssFormatter;
        //    }
        //}



        //[OperationContract]
        //[WebGet(UriTemplate = "Emps?empno={empno}", ResponseFormat = WebMessageFormat.Json)]
        //Salarie GetEmpById(string empno);

        //[OperationContract]
        //[WebGet(UriTemplate = "Emps/{deptno}", ResponseFormat = WebMessageFormat.Json)]
        //List<Salarie> GetEmpsByDeptno(string deptno);

        //[OperationContract]
        //[WebGet(UriTemplate = "Emps", ResponseFormat = WebMessageFormat.Json)]
        //List<Salarie> GetEmps();

        ////[OperationContract]

        //void NewEmp(int empno, string ename, double sal, int deptno);



    }
}
