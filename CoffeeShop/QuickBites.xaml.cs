using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeShop
{
    public partial class QuickBites : ContentPage
    {
        public QuickBites()
        {
            InitializeComponent();
        }

    private async   void backButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
