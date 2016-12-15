using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TribuneDevMETIER;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace TribuneDevWinPhone
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class DetailsPage : Page
    {
      

        private ReponseViewModel _reponseViewModel = null;

        public DetailsPage()
        {

            this.InitializeComponent();
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            

            // On récupère le ViewModel (UserViewModel). UserViewModel est la source de données
            _reponseViewModel = (ReponseViewModel)e.Parameter;

            // Binding de la source de données (UserViewModel) avec le contexte de la page
            DataContext = _reponseViewModel;

            // On fixe le titre de la page
            txtTitre.Text = txtTitre.Text + _reponseViewModel.IdSujet;

            txtNomUser.Text = txtNomUser.Text + _reponseViewModel.IdUser;
            txtDateEnvoi.Text = txtDateEnvoi.Text + _reponseViewModel.DateEnvoiRep;
            txtTextRep.Text = txtTextRep.Text + _reponseViewModel.TextRep;
            



            // On s'abonne à l'événement système 'HardwareButtons_BackPressed'          
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;

            

            //// On rafraichit la liste des réponses
            //await _monitorViewModel.GetListReponses(CancellationToken.None);
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            // On se désabonne de l'événement système 'HardwareButtons_BackPressed'
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            e.Handled = true;
            Frame.Navigate(typeof(MainPage));
        }

        private void mnuQuitter_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }


    }
}
