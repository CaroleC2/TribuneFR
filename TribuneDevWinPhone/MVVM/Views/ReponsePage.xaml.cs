﻿using System;
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

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace TribuneDevWinPhone
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class ReponsePage : Page
    {
        private SujetViewModel _sujetViewModel = null;

        public ReponsePage()
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
            _sujetViewModel = (SujetViewModel)e.Parameter;
            // Binding de la source de données (MonitorViewModel) avec le contexte de la page
            DataContext = _sujetViewModel;

            // On s'abonne à l'événement système 'HardwareButtons_BackPressed'          
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;


            // On rafraichit la liste des rubriques
            await _sujetViewModel.GetListReponses(CancellationToken.None);

            
        }

        protected override void OnNavigatingFrom
           (NavigatingCancelEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }


        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ReponseViewModel reponseViewModel = (ReponseViewModel)((Button)sender).DataContext;
            Frame.Navigate(typeof(DetailsPage), reponseViewModel);
        }

  
        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            // Retour à la fenêtre appelante
            if (Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }

        private void mnuQuitter_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }
    }
}
