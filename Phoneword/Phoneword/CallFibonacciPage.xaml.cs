using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class CallFibonacciPage : ContentPage
    {
        public CallFibonacciPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            int roundedValue = (int) Math.Round(value);
            displayLabel.Text = String.Format("N = {0}", roundedValue);
            fibonacciLabel.Text = String.Format("Fib = {0}", App.FibonacciNumbers[roundedValue-1]);
        }
    }
}
