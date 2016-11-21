using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfWSTribuneREST
{
    [DataContract]
    public class Utilisateur
    {
        [DataMember]
        public int IdUser { get; set; }

        [DataMember]
        public string NomUser { get; set; }

        [DataMember]
        public string MdpUser { get; set; }

        [DataMember]
        public int DroitUser { get; set; }

        public Utilisateur(int iduser, string nomuser, string mdpuser, int droituser)
        {
            this.IdUser = iduser;
            this.NomUser = nomuser;
            this.MdpUser = mdpuser;
            this.DroitUser = droituser;
        }
        public Utilisateur()
        {
        }
    }
}
