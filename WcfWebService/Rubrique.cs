using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfWebService
{
    [DataContract]
    public class Rubrique
    {
        [DataMember]
        public int IdRub { get; set; }

        [DataMember]
        public string NomRub { get; set; }

        [DataMember]
        public string TextRub { get; set; }

        

        public Rubrique(int idrub, string nomrub, string textrub)
        {
            this.IdRub = idrub;
            this.NomRub = nomrub;
            this.TextRub = textrub;
        }
        public Rubrique()
        {
        }
    }
}
