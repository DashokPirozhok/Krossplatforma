using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class Page1 : ContentPage
    {
        public Page1()

        {
            Entry Entry1 = new Entry
            {
                Placeholder = "write",
                TextColor = Color.Aqua
            };

            Button Button1 = new Button
            {
                Text = "tap",
                
            };

            Label Label1 = new Label
            {
                Text ="hello"
            };

            Content = new StackLayout
            {
                Children = {
                   Entry1, Button1, Label1
                }
            };
        }
    }
}