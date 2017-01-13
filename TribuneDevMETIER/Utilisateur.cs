using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribuneDevMETIER
{
    /// <summary>
    /// Classe Métier Utilisateur
    /// </summary>
    public class Utilisateur
    {
        private int _IdUser;
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        public int IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }



        private string _NomUser;
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string NomUser
        {
            get { return _NomUser; }
            set { _NomUser = value; }
        }


        private string _MdpUser;
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string MdpUser
        {
            get { return _MdpUser; }
            set { _MdpUser = value; }
        }

        private int _DroitUser;
        /// <summary>
        /// Droit de l'utilisateur
        /// </summary>
        public int DroitUser
        {
            get { return _DroitUser; }
            set { _DroitUser = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur()
        {

        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="nomUser"></param>
        /// <param name="mdpUser"></param>
        /// <param name="droitUser"></param>
        public Utilisateur(int idUser, string nomUser, string mdpUser, int droitUser)
        {

            this.IdUser = idUser;
            this.NomUser = nomUser;
            this.MdpUser = mdpUser;
            this.DroitUser = droitUser;
        }


        public override string ToString()
        {
            return "Numero Utilisateur " + IdUser +
                    "Login : " + NomUser +
                    "Password :" + MdpUser +
                    "Droit utilisateur" + DroitUser;
        }
    }
}
