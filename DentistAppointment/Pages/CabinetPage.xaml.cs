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
    public partial class CabinetPage : ContentPage
    {
        public CabinetPage()
        {
            InitializeComponent();
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CabinetAdd()));
        }

        async void DeleteAll_Clicked(object sender, EventArgs e)
        {
            using (var context = new Services.Context())
            {
                context.RemoveRange(context.Cabinete);

                await context.SaveChangesAsync();

                blobCollectionView.ItemsSource = context.Cabinete.ToList();
            }
        }
    }
}