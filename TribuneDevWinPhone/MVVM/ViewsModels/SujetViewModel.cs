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

namespace TribuneDevWinPhone
{

    public class SujetViewModel : ViewModelBase, IComparable<SujetViewModel>, IEquatable<SujetViewModel>
    {
        private ConsumeWSR _consumeWSR;
        private int _idsujet;
        private int _idrub;
        private int _iduser;
        private string _titresujet;
        private string _textsujet;
        private DateTime _datecreatsujet;
        private string _nomuser;
        private string _errorMessage;
        private ObservableCollection<ReponseViewModel> _colReponsesViewModel;
        
        #region Constructeurs

        // Constructeur internal car c'est la classe MonitorViewModel qui construit les Sujets
        internal SujetViewModel(Sujet sujet ,ConsumeWSR consumeWSR)
        {
            _idsujet = sujet.IdSujet;
            _idrub = sujet.IdRub;
            _iduser = sujet.IdUser;
            _titresujet = sujet.TitreSujet;
            _textsujet = sujet.TextSujet;
            _datecreatsujet = sujet.DateCreatSujet;
            _nomuser = sujet.NomUser;
            _colReponsesViewModel = new ObservableCollection<ReponseViewModel>();
            _consumeWSR = consumeWSR;

        }

        #endregion Constructeurs

        #region Propriétés Bindables

        public int IdSujet
        {
            get { return _idsujet; }
            private set
            {
                if (_idsujet != value)
                {
                    _idsujet = value;
                    RaisePropertyChanged();
                }
            }

        }

        public int IdRub
        {
            get { return _idrub; }
            private set
            {
                if (_idrub != value)
                {
                    _idrub = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int IdUser
        {
            get { return _iduser; }
            private set
            {
                if (_iduser != value)
                {
                    _iduser = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string TitreSujet
        {
            get { return _titresujet; }
            private set
            {
                if (_titresujet != value)
                {
                    _titresujet = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string TextSujet
        {
            get { return _textsujet; }
            private set
            {
                if (_textsujet != value)
                {
                    _textsujet = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime DateCreatSujet
        {
            get { return _datecreatsujet; }
            private set
            {
                if (_datecreatsujet != value)
                {
                    _datecreatsujet = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string NomUser
        {
            get { return _nomuser; }
            private set
            {
                if (_nomuser != value)
                {
                    _nomuser = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            private set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ReadOnlyObservableCollection<ReponseViewModel> Reponses
        {
            get { return new ReadOnlyObservableCollection<ReponseViewModel>(_colReponsesViewModel); }
        }

        #endregion Propriétés Bindables

        #region Méthodes

        public async Task GetListReponses(CancellationToken cancel)
        {
            //On apelle le webservice qui renvoi une liste de rubrique
            List<Reponse> reponses = await _consumeWSR.CallReponse(IdSujet.ToString(), cancel);
            //A partir de cette liste de rubriques on met à jour la collection observable
            MAJ_ListeReponse(reponses);

        }



        #endregion Méthodes

        #region Fonctions perso


        private void MAJ_ListeReponse(List<Reponse> lstReponses)
        {
            if (lstReponses.Count != 0)
            {
                _colReponsesViewModel.Clear();

                // Ajout des nouvelles rubriques
                foreach (Reponse rep in lstReponses)
                {
                    ReponseViewModel reponseVm = new ReponseViewModel(rep, _consumeWSR);

                    if (!_colReponsesViewModel.Contains(reponseVm))
                    {
                        // On utilise la méthode d'extention de la classe 'IListExtensions'
                        _colReponsesViewModel.AddSorted(reponseVm);
                    }
                }
            }
            else
            {
                ErrorMessage = "Le sujet sélectionné ne contient pas de réponses.";
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
