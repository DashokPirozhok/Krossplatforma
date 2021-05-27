using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

       /* private void Button_Clicked(object sender, EventArgs e)
        {
            Label1.Text = Entry1.Text; 
        }*/

        private async void Button_lavel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lavel());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}