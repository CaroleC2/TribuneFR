﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Sujet
    {
        private int _IdSujet;

        public int IdSujet
        {
            get { return _IdSujet; }
            set { _IdSujet = value; }
        }


        private int _IdRub;

        public int IdRub
        {
            get { return _IdRub; }
            set { _IdRub = value; }
        }


        private int _IdUser;

        public int IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }


        private string _TitreSujet;

        public string TitreSujet
        {
            get { return _TitreSujet; }
            set { _TitreSujet = value; }
        }


        private string _TextSujet;

        public string TextSujet
        {
            get { return _TextSujet; }
            set { _TextSujet = value; }
        }


        private DateTime _DateCreatSujet;

        public DateTime DateCreatSujet
        {
            get { return _DateCreatSujet; }
            set { _DateCreatSujet = value; }
        }

        public Sujet()
        {

        }

        public Sujet(int idSujet, int idRub, int idUser, string titreSujet, string textSujet, DateTime dateCreatSujet)
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
            return  "Numero Sujet "    + IdSujet       +
                    "Numero Rubrique"  + IdRub         +
                    "Numero User"      + IdUser        +
                    "Titre : "         + TitreSujet    +
                    "Texte :"          + TextSujet     +
                    "Date de création" + DateCreatSujet;
        }
    

    }
}
