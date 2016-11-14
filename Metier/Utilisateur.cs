using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{

        public class Utilisateur
        {
            private int _IdUser;

            public int IdUser
        {
                get { return _IdUser; }
                set { _IdUser = value; }
            }

        

            private string _NomUser;

            public string NomUser
        {
                get { return _NomUser; }
                set { _NomUser = value; }
            }


            private string _MdpUser;

            public string MdpUser
            {
                get { return _MdpUser; }
                set { _MdpUser = value; }
            }

            private int _DroitUser;

            public int DroitUser
        {
                get { return _DroitUser; }
                set { _DroitUser = value; }
            }


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

