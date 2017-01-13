using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TribuneDevMETIER
{
    /// <summary>
    /// Classe métier Réponse
    /// </summary>
    [DataContract]
    public class Reponse
    {
            
            [DataMember] private int _IdRep;

            /// <summary>
            /// Identifiant de la réponse
            /// </summary>
            public int IdRep
            {
                get { return _IdRep; }
                set { _IdRep = value; }
            }

            [DataMember] private int _IdSujet;
            
            /// <summary>
            /// Identifiant du sujet correspondant à la réponse
            /// </summary>
            public int IdSujet
            {
                get { return _IdSujet; }
                set { _IdSujet = value; }
            }

            [DataMember] private int _IdUser;
            
            /// <summary>
            /// Identifiant de l'utilisateur qui a publié la réponse
            /// </summary>
            public int IdUser
            {
                get { return _IdUser; }
                set { _IdUser = value; }
            }


            [DataMember] private string _TextRep;
            
            /// <summary>
            /// Texte de la réponse
            /// </summary>
            public string TextRep
            {
                get { return _TextRep; }
                set { _TextRep = value; }
            }

            [DataMember] private DateTime _DateEnvoiRep;
            
            /// <summary>
            /// Date d'envoi de la réponse
            /// </summary>
            public DateTime DateEnvoiRep
            {
                get { return _DateEnvoiRep; }
                set { _DateEnvoiRep = value; }
            }


        [DataMember]
        private string _NomUser;

        /// <summary>
        /// Nom de l'utilisateur qui a posté la réponse
        /// </summary>
        public string NomUser
        {
            get { return _NomUser; }
            set { _NomUser = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Reponse()
            {

            }
            
            /// <summary>
            /// Constructeur
            /// </summary>
            /// <param name="idRep"></param>
            /// <param name="idSujet"></param>
            /// <param name="idUser"></param>
            /// <param name="textRep"></param>
            /// <param name="dateEnvoiRep"></param>
            public Reponse(int idRep, int idSujet, int idUser, string textRep, DateTime dateEnvoiRep)
            {
                this.IdRep = idRep;
                this.IdSujet = idSujet;
                this.IdUser = idUser;
                this.TextRep = textRep;
                this.DateEnvoiRep = dateEnvoiRep;
            }


            public override string ToString()
            {
                return "Numero Rubrique" + IdRep +
                       "Numero Sujet " + IdSujet +
                       "Numero User" + IdUser +
                       "Texte :" + TextRep +
                       "Date d'envoi :" + DateEnvoiRep;
            }



        }
    }

