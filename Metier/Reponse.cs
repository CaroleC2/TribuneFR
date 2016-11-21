using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{

        public class Reponse
        {
            private int _IdRep;

            public int IdRep
            {
                get { return _IdRep; }
                set { _IdRep = value; }
            }


            private int _IdSujet;

            public int IdSujet
            {
                get { return _IdSujet; }
                set { _IdSujet = value; }
            }


            private int _IdUser;

            public int IdUser
            {
                get { return _IdUser; }
                set { _IdUser = value; }
            }



            private string _TextRep;

            public string TextRep
        {
                get { return _TextRep; }
                set { _TextRep = value; }
            }


            private DateTime _DateEnvoiRep;

            public DateTime DateEnvoiRep
        {
                get { return _DateEnvoiRep; }
                set { _DateEnvoiRep = value; }
            }


            public Reponse()
            {

            }

            public Reponse(int idRep,int idSujet,  int idUser,  string textRep, DateTime dateEnvoiRep)
            {
                this.IdRep = idRep;
                this.IdSujet = idSujet;
                this.IdUser = idUser;
                this.TextRep = textRep;
                this.DateEnvoiRep = dateEnvoiRep;
            }


            public override string ToString()
            {
                return  "Numero Rubrique" + IdRep +
                        "Numero Sujet "   + IdSujet +
                        "Numero User"     + IdUser +
                        "Texte :"         + TextRep +
                        "Date d'envoi :"  + DateEnvoiRep;
            }



        }
    }

