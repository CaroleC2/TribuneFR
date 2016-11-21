using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfWSTribuneREST
{
    [DataContract]
    public class Reponse
    {
        [DataMember]
        public int IdRep { get; set; }

        [DataMember]
        public int IdUser { get; set; }

        [DataMember]
        public int IdSujet { get; set; }

        [DataMember]
        public string TextRep { get; set; }

        [DataMember]
        public DateTime DateEnvoiRep { get; set; }

        public Reponse(int idrep, int iduser, int idsujet, string textrep, DateTime dateenvoirep)
        {
            this.IdRep = idrep;
            this.IdUser = iduser;
            this.IdSujet = idsujet;
            this.TextRep = textrep;
            this.DateEnvoiRep = dateenvoirep;

        }
        public Reponse()
        {
        }
    }
    }
