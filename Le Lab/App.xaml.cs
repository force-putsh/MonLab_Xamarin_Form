using Le_Lab.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Le_Lab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageDeMenu());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
