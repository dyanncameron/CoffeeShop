using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeShop
{
    public partial class ColdDrinks : ContentPage
    {
        public ColdDrinks()
        {
            InitializeComponent();
        }

    private async void backButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}
