using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TribuneDevMETIER
{
    #region PROPRIETES

    [DataContract]
    public class Rubrique
    {
        [DataMember]
        private int _IdRub;

        public int IdRub
        {
            get { return _IdRub; }
            set { _IdRub = value; }
        }


        [DataMember]
        private string _NomRub;

        public string NomRub
        {
            get { return _NomRub; }
            set { _NomRub = value; }
        }

        [DataMember]
        private string _TextRub;

        public string TextRub
        {
            get { return _TextRub; }
            set { _TextRub = value; }
        }

#endregion


        #region CONSTRUCTEURS
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Rubrique()
        { }



        public Rubrique(int idRub, string nomRub, string textRub)
        {
            this.IdRub = idRub;
            this.NomRub = nomRub;
            this.TextRub = textRub;

        }

        #endregion


        #region METHODES
        public override string ToString()
        {
            return "Numero Rubrique: " + IdRub +
                    "Nom : " + NomRub +
                    "Texte :" + TextRub;
        }


        #endregion

    }
}
