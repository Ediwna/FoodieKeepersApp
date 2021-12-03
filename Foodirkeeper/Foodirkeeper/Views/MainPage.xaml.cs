using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Foodirkeeper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            //button1.Text = "Success";
            Button b = sender as Button;
            b.Text = "Success";
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
            
        }

    }
}
