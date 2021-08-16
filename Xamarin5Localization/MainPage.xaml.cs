using System.ComponentModel;
using Xamarin5Localization.Resources;
using Xamarin5Localization.Views;
using Xamarin.Forms;

namespace Xamarin5Localization
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ChangeLanguagePage())); 
        }
    }
}
