using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class CallMediaPage : ContentPage
    {
        public CallMediaPage()
        {
            InitializeComponent();
        }

        async void OnGallery(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CallFibonacciPage());
        }

        async void OnCamera(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CallFibonacciPage());
        }
    }
}
