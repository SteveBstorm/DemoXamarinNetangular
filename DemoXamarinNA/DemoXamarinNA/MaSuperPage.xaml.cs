using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXamarinNA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaSuperPage : ContentPage
    {
        public ObservableCollection<Personne> liste { get; set; }

        private Personne _selectedPerson;

        public Personne SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if(_selectedPerson != value)
                {
                    _selectedPerson = value;
                    App.Current.MainPage.Navigation.PushModalAsync(new Detail(_selectedPerson));
                }
            }
        }

        public MaSuperPage()
        {
            BindingContext = this;
            liste = new ObservableCollection<Personne>
            {
                new Personne
                {
                    Nom = "Arthur",
                    Email = "arthur@cuillere.com"
                },
                new Personne
                {
                    Nom = "Karadoc",
                    Email = "legras@clavie.com"
                }
            };

            InitializeComponent();
        }
    }
}