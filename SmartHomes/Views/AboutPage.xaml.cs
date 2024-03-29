﻿using Rg.Plugins.Popup.Extensions;
using SmartHomes.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHomes.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }

         private void showPopUp(object sender, EventArgs e)
        {
            var pop = new popUpPage();
            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);

        }
    }
}