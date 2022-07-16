using tarea2_2movil2.Controllers;
using tarea2_2movil2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_2movil2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class firmaListas : ContentPage
    {
        public firmaListas()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listaFirmas.ItemsSource = await App.BaseDatosObject.GetFirmasList();
        }
    }
}