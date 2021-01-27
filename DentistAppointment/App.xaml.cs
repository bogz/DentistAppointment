using DentistAppointment.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DentistAppointment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CabinetPage());
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