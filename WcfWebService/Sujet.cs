using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfWebService
{
    public class Sujet
    {
        [DataMember]
        public int IdSujet { get; set; }

        [DataMember]
        public int IdRub { get; set; }

        [DataMember]
        public int IdUser { get; set; }

        [DataMember]
        public string TitreSujet { get; set; }

        [DataMember]
        public string TextSujet { get; set; }

        [DataMember]
        public DateTime DateCreatSujet { get; set; }

        public Sujet(int idsujet, int idrub, int iduser, string titresujet, string textsujet, DateTime datecreatsujet)
        {
            this.IdSujet = idsujet;
            this.IdRub = idrub;
            this.IdUser = iduser;
            this.TitreSujet = titresujet;
            this.TextSujet = textsujet;
            this.DateCreatSujet = datecreatsujet;

        }
        public Sujet()
        {
        }
    }
}
