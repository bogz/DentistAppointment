﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DentistAppointment.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramariAdd : ContentPage
    {
        public ProgramariAdd()
        {
            InitializeComponent();
        }

        async void Save_Clicked(System.Object sender, System.EventArgs e)
        {
            var programare = new Programare { };

            using (var context = new Services.Context())
            {
                context.Add(programare);

                await context.SaveChangesAsync();
            }

            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}