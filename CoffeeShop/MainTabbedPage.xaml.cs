using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void coffeeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EspressoDrinksDetailPage());
        }

        private async void hotcoffeeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksDetailPage());
        }

        private async void coldDrinks_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinks());
        }

        private async void quickBites_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new QuickBites());
        }
    }
}
