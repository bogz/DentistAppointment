using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DentistAppointment.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientPage : ContentPage
    {
        public ClientPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (var context = new Services.Context())
            {
                blobCollectionView.ItemsSource = context.Clienti.ToList();
            }
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ClientAdd()));
        }

        async void DeleteAll_Clicked(object sender, EventArgs e)
        {
            using (var context = new Services.Context())
            {
                context.RemoveRange(context.Clienti);

                await context.SaveChangesAsync();
            }
        }
    }
}