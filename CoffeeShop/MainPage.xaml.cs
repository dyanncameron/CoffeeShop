﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeShop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void coffeeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EspressoDrinksDetailPage());
        }
    }
}
