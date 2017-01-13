using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TribuneDevMETIER
{
    /// <summary>
    /// Classe Métier Sujet
    /// </summary>
    [DataContract]
    public class Sujet
    {
       
            [DataMember] private int _IdSujet;
            /// <summary>
            /// Identifiant du sujet
            /// </summary>
            public int IdSujet
            {
                get { return _IdSujet; }
                set { _IdSujet = value; }
            }

            [DataMember] private int _IdRub;
            /// <summary>
            /// Identifiant de la rubrique contenant le sujet
            /// </summary>
            public int IdRub
            {
                get { return _IdRub; }
                set { _IdRub = value; }
            }

            [DataMember] private int _IdUser;
            /// <summary>
            /// Identifiant de l'Id de l'utilisateur ayant créé le sujet
            /// </summary>
            public int IdUser
            {
                get { return _IdUser; }
                set { _IdUser = value; }
            }

            [DataMember] private string _TitreSujet;
            /// <summary>
            /// Titre du sujet
            /// </summary>
            public string TitreSujet
            {
                get { return _TitreSujet; }
                set { _TitreSujet = value; }
            }

            [DataMember] private string _TextSujet;
            /// <summary>
            /// Texte du sujet
            /// </summary>
            public string TextSujet
            {
                get { return _TextSujet; }
                set { _TextSujet = value; }
            }

            [DataMember] private DateTime _DateCreatSujet;
            /// <summary>
            /// Date de création du sujet
            /// </summary>
            public DateTime DateCreatSujet
            {
                get { return _DateCreatSujet; }
                set { _DateCreatSujet = value; }
            }

        [DataMember]
        private string _NomUser;
        /// <summary>
        /// Nom de l'utilisateur ayant créé le sujet
        /// </summary>
        public string NomUser
        {
            get { return _NomUser; }
            set { _NomUser = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Sujet()
            {

            }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idSujet"></param>
        /// <param name="idRub"></param>
        /// <param name="idUser"></param>
        /// <param name="titreSujet"></param>
        /// <param name="textSujet"></param>
        /// <param name="dateCreatSujet"></param>
            public Sujet(int idSujet, int idRub, int idUser, string titreSujet, string textSujet,
                DateTime dateCreatSujet)
            {
                this.IdSujet = idSujet;
                this.IdRub = idRub;
                this.IdUser = idUser;
                this.TitreSujet = titreSujet;
                this.TextSujet = textSujet;
                this.DateCreatSujet = dateCreatSujet;
            }


            public override string ToString()
            {
                return "Numero Sujet " + IdSujet +
                       "Numero Rubrique" + IdRub +
                       "Numero User" + IdUser +
                       "Titre : " + TitreSujet +
                       "Texte :" + TextSujet +
                       "Date de création" + DateCreatSujet;
            }


        }
    }

