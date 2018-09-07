using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class CatPage : ContentPage
    {
        public CatPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Cats";
            Label pic = new Label
            {
                Text = ("This is my old kittie, Piccolo."),
                FontSize = 25,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image piccolo = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.piccolo.png"),
                HeightRequest = 250,
                WidthRequest = 250,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            Label mick = new Label
            {
                Text = ("This is Micky AKA 'Big Boy'."),
                FontSize = 25,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };

            Image micky = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.micky.png"),
                HeightRequest = 250,
                WidthRequest = 250,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            var stackLayout = new StackLayout
            {
                Children = { pic, piccolo, mick, micky }

            };

            this.Content = stackLayout;
        }
    }
}
