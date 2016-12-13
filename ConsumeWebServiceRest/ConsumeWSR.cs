using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;
using TribuneDevMETIER;

namespace ConsumeWebServiceRest
{
   
        
        public class ConsumeWSR
        {

            
            private const string ADRESSE_GET = "http://user10.2isa.org/ServiceFR.svc/" ;
            private const string ADRESSE_GET_RUBRIQUE = ADRESSE_GET + ("Rubrique");
            private const string ADRESSE_GET_SUJET = ADRESSE_GET_RUBRIQUE + ("Sujet/{0}");
            private const string ADRESSE_GET_REPONSE = ADRESSE_GET_SUJET + ("Reponse/{0}");

            private List<Rubrique> _rubriques = new List<Rubrique>();
            private List<Sujet> _sujets = new List<Sujet>();
            private List<Reponse> _reponses = new List<Reponse>();




            #region RUBRIQUE

           
            public async Task<List<Rubrique>> CallRubrique(CancellationToken cancel)
            {
                // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
                // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
                using (HttpClient client = new HttpClient() {Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite)})
                {
                    // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                    // qui a été mis en cache
                    client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                    //// Sérialisation des paramètres
                    //using (StringContent contentParametres = SerializeParam(parametres))
                    //{
                    // Appel du service Rest (en asynchrone)
                    using (HttpResponseMessage wcfResponse = await client.GetAsync(ADRESSE_GET_RUBRIQUE, cancel))
                    {
                        if (wcfResponse.IsSuccessStatusCode)
                        {
                            // Désérialisation de la réponse du service
                            return DeserializeHttpContent(wcfResponse.Content);
                        }
                        return null;
                    }
                }

            }


            /// <summary>
            /// Cette méthode permet de désérialiser un objet
            /// </summary>
            /// <param name="content">Objet à désérialiser</param>
           
            /// <returns>Objet désérialisé</returns>
            private List<Rubrique> DeserializeHttpContent(HttpContent content)
            {
                
                    using (Stream s = content.ReadAsStreamAsync().Result)
                    {
                        if (s.Length > 0)
                        {
                            return _rubriques = (List<Rubrique>)new DataContractSerializer(typeof(List<Rubrique>)).ReadObject(s);
                        
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            #endregion RUBRIQUE


            #region SUJET
            
            public async Task<List<Sujet>> CallSujet(string idsujet,CancellationToken cancel)
            {
                // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
                // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
                using (HttpClient client = new HttpClient() {Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite)})
                {
                    // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                    // qui a été mis en cache
                    client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                    // Appel du service Rest (en asynchrone)
                    using (HttpResponseMessage wcfResponse = await client.GetAsync(string.Format(ADRESSE_GET_SUJET,idsujet), cancel))
                    {
                        if (wcfResponse.IsSuccessStatusCode)
                        {
                            // Désérialisation de la réponse du service
                            return DeserializeSujetHttpContent(wcfResponse.Content);
                        }
                        return null;
                    }
                }

            }
            

            /// <summary>
            /// Cette méthode permet de désérialiser un objet
            /// </summary>
            /// <param name="content">Objet à désérialiser</param>

            /// <returns>Objet désérialisé</returns>
            private List<Sujet> DeserializeSujetHttpContent(HttpContent content)
            {

                using (Stream s = content.ReadAsStreamAsync().Result)
                {
                    if (s.Length > 0)
                    {

                        return _sujets = (List<Sujet>)new DataContractSerializer(typeof(List<Sujet>)).ReadObject(s);


                    }
                    else
                    {
                        return null;
                    }
                }
            }
            #endregion SUJET


            #region REPONSE

            /// <summary>
            /// Appel d'un Service REST qui retourne un objet de type WSR_Result en réponse. 
            /// Cette opération peut être annulée
            /// </summary>
            /// <param name="adresseService">Adresse du service</param>


            /// <param name="cancel">Jeton permettant d'annuler l'appel en cours</param>
            /// <returns>Objet retourné par le service ou Erreur, de type WSR_Result</returns>
            public async Task<List<Reponse>> CallReponse(string idreponse, CancellationToken cancel)
            {
                // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
                // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
                using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
                {
                    // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                    // qui a été mis en cache
                    client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                    //// Sérialisation des paramètres
                    //using (StringContent contentParametres = SerializeParam(parametres))
                    //{
                    // Appel du service Rest (en asynchrone)
                    using (HttpResponseMessage wcfResponse = await client.GetAsync(String.Format(ADRESSE_GET_REPONSE,idreponse),cancel))
                    {
                        if (wcfResponse.IsSuccessStatusCode)
                        {
                            // Désérialisation de la réponse du service
                            return DeserializeReponseHttpContent(wcfResponse.Content);
                        }
                        return null;
                    }
                }

            }


            /// <summary>
            /// Cette méthode permet de désérialiser un objet
            /// </summary>
            /// <param name="content">Objet à désérialiser</param>

            /// <returns>Objet désérialisé</returns>
            private List<Reponse> DeserializeReponseHttpContent(HttpContent content)
            {

                using (Stream s = content.ReadAsStreamAsync().Result)
                {
                    if (s.Length > 0)
                    {

                        return _reponses = (List<Reponse>)new DataContractSerializer(typeof(List<Reponse>)).ReadObject(s);


                    }
                    else
                    {
                        return null;
                    }
                }
            }
            #endregion REPONSE

        }

    
}

