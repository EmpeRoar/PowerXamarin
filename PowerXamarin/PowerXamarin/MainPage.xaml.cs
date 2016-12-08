﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PowerXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnCall(object sender, EventArgs e)
        {
            pageLabel.Text = pageEntry.Text;
        }

        async void OnRedirect(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactFormPage());
        }
    }
}
