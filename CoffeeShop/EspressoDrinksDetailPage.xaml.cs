using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeShop
{
    public partial class EspressoDrinksDetailPage : ContentPage
    {
        public EspressoDrinksDetailPage()
        {
            InitializeComponent();
        }

        private async void backButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //await Navigation.PopAsync();
            await Navigation.PopToRootAsync();
        }
    }
}
