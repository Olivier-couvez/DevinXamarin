using JeuDevinXamarin.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JeuDevinXamarin.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JeuDevin : ContentPage
    {
        public JeuDevin()
        {
            InitializeComponent();
            BindingContext = new JeuDevinViewModel();
        }
    }
}