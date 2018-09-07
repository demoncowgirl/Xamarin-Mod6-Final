using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class ParrotPage : ContentPage
    {
        public ParrotPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Cockatoo";
            Label peaches = new Label
            {
                Text = ("This is my Moluccan Cockatoo, Peachybutt."),
                FontSize = 25,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image peachybutt = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.peachybutt.png"),
                HeightRequest = 400,
                WidthRequest = 400,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };
            var stackLayout = new StackLayout
            {
                Children = { peaches, peachybutt }

            };

            this.Content = stackLayout;
        }
    }
}
