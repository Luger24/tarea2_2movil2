using tarea2_2movil2.Controllers;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_2movil2
{
    public partial class App : Application
    {
        static firmadb BaseDatos;

        public static firmadb BaseDatosObject
        {
            get
            {
                if (BaseDatos == null)
                {
                    BaseDatos = new firmadb(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FirmasDB.db3"));
                }
                return BaseDatos;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
