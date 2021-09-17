using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Le_Lab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDeMenu : ContentPage
    {
        public PageDeMenu()
        {
            InitializeComponent();
        }

        private void btnCompter_Clicked(object sender, EventArgs e)
        {
            CountPage page = new CountPage();
            this.Navigation.PushAsync(page);
        }
        
        private void btnTabs_Clicked(object sender, EventArgs e)
        {
            PageContenu page = new PageContenu();
            this.Navigation.PushAsync(page);
        }

        private void btnListe_Clicked(object sender, EventArgs e)
        {
            Liste page = new Liste();
            this.Navigation.PushAsync(page);
        }
    }
}