using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeWebServiceRest;
using System.Collections.ObjectModel;
using System.Threading;
using TribuneDevMETIER;
using TribuneDevWinPhone.MVVM.Extensions;

namespace TribuneDevWinPhone.MVVM.ViewsModels
{

    public class SujetViewModel : ViewModelBase, IComparable<SujetViewModel>, IEquatable<SujetViewModel>
    {
        private ConsumeWebServiceRest.ConsumeWSR _consumeWSR;
        private int _idsujet;
        private int _idrub;
        private int _iduser;
        private string _titresujet;
        private string _textsujet;
        private DateTime _datecreatsujet;
        private ObservableCollection<ReponseViewModel> _colReponsesViewModel;
        
        #region Constructeurs

        // Constructeur internal car c'est la classe MonitorViewModel qui construit les Rubriques
        internal SujetViewModel(Sujet sujet ,ConsumeWSR consumeWSR)
        {
            _idsujet = sujet.IdSujet;
            _idrub = sujet.IdRub;
            _iduser = sujet.IdUser;
            _titresujet = sujet.TitreSujet;
            _textsujet = sujet.TextSujet;
            _datecreatsujet = sujet.DateCreatSujet;
            _consumeWSR = consumeWSR;

        }

        #endregion Constructeurs

        #region Propriétés

        public int IdSujet
        {
            get { return _idsujet; }
        }

        public int IdRub
        {
            get { return _idrub; }
        }

        public int IdUser
        {
            get { return _iduser; }
        }
        public string TitreSujet
        {
            get { return _titresujet; }
        }

        public string TextSujet
        {
            get { return _textsujet; }
        }

        public DateTime DateCreateSujet
        {
            get { return _datecreatsujet; }
        }

        public ReadOnlyObservableCollection<ReponseViewModel> Reponses
        {
            get { return new ReadOnlyObservableCollection<ReponseViewModel>(_colReponsesViewModel); }
        }
        #endregion Propriétés


      
        #region Méthodes

        public async Task GetListSujets(CancellationToken cancel)
        {
            //On apelle le webservice qui renvoi une liste de rubrique
            List<Sujet> sujets = await _consumeWSR.CallSujet(cancel);
            //A partir de cette liste de rubriques on met à jour la collection observable
            MAJ_ListeSujets(sujets);

        }

        #endregion Méthodes

        #region Fonctions perso


        private void MAJ_ListeSujets(List<Sujet> lstSujets)
        {
            _colReponsesViewModel.Clear();

            // Ajout des nouvelles rubriques
            foreach (Sujet sujet in lstSujets)
            {
                ReponseViewModel sujetVm = new ReponseViewModel(sujet, _consumeWSR);

                if (!_colReponsesViewModel.Contains(sujetVm))
                {
                // On utilise la méthode d'extention de la classe 'IListExtensions'
                _colReponsesViewModel.AddSorted(sujetVm);
                }
            }
        }

        #endregion Fonctions perso

        #region ToString

        public override string ToString()
        {
            return TitreSujet;
        }

        #endregion ToString
        

        #region IComparable<SujetVM> Membres

        public int CompareTo(SujetViewModel other)
        {
            return TitreSujet.CompareTo(other.TitreSujet);
        }

        #endregion

        #region IEquatable<SujetVM> Membres

        public bool Equals(SujetViewModel other)
        {
            return TitreSujet.Equals(other.TitreSujet);
        }

        public override int GetHashCode()
        {
            return TitreSujet.GetHashCode();
        }

        #endregion
    }
}
