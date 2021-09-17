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
    public partial class Liste : ContentPage
    {
        public class Article
        {
            public string Nom { get; set; }
            public string Prix { get; set; }
            public string Description { get; set; }
        }
        public Liste()
        {
            InitializeComponent();
            List<Article> articles = new List<Article>();
            articles.Add(new Article { Nom = "Pain", Prix = "1dh", Description="Du bon pain chaud" });
            articles.Add(new Article { Nom = "Chocolat", Prix = "25dh", Description="Le Chocolat Noisetta" });
            articles.Add(new Article { Nom = "Mayonnaise", Prix = "8dh", Description="De la Mayonnaise Calvé" });
            articles.Add(new Article { Nom = "Banane", Prix = "5dh" , Description="Banane Fraiche"});

            MaSource.ItemsSource = articles;

            MaSource.ItemSelected += (sender, e) =>
             {
                 if (MaSource.SelectedItem!=null)
                 {
                     Article item = MaSource.SelectedItem as Article;
                     DisplayAlert(item.Nom, item.Description, "ok");
                     MaSource.SelectedItem = null;
                 }
             };
        }
    }
}