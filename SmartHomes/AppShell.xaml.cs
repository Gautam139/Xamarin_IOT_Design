using SmartHomes.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmartHomes
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        async void Navigate(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new ItemsPage());
            // Manually deselect item.
        }
    }
}
