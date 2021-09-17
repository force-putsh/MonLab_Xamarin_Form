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
    public partial class CountPage : ContentPage
    {
        int i = 0;

        public CountPage()
        {
            InitializeComponent();
        }

        private void Increm_Clicked(object sender, EventArgs e)
        {
            i++;
            lab_Afficher.Text = i.ToString();
        }
    }
}