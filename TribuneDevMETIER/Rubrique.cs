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

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Rubrique r = (Rubrique)obj;
            return (IdRub == r.IdRub && NomRub == r.NomRub)  ;


        }

        //public bool Equals(Rubrique x, Rubrique y)
        //{
        //    if (object.ReferenceEquals(x, y)) return true;

        //    if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;

        //    return x.IdRub == y.IdRub && x.NomRub == y.NomRub && x.TextRub == y.TextRub;
        //}

        public int GetHashCode(Rubrique rub)
        {
            if (object.ReferenceEquals(rub, null)) return 0;

            int hashCodeIdRub = rub.IdRub == null ? 0 : rub.IdRub.GetHashCode();
            int hashCodeNomRub = rub.NomRub.GetHashCode();
            int hasCodeTextRub = rub.TextRub.GetHashCode();

            return hashCodeIdRub ^ hashCodeNomRub ^ hasCodeTextRub;
        }
    }
        #endregion

    }

