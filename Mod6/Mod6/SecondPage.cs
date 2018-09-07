using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class SecondPage : ContentPage
    {
        Button secondButton;
        public SecondPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Fiance";

            Label homeLabel = new Label
            {
                Text = "My Fiance, Mike",
                FontSize = 40,
                TextColor = Color.Red,
            };

            Label labelBethMike = new Label
            {
                Text = "This is me and my fiance, Mike, at the Triple Rock in Minneapolis, MN.",
                Margin = 5,
                TextColor = Color.Black,
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center
            };

            Image mike = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.bethmike.png"),
                HeightRequest = 350,
                WidthRequest = 350,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            Image trouble = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.trouble.png"),
                WidthRequest = 225,
                HeightRequest = 225,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            secondButton = new Button
            {
                Text = "Go to My Zoo"
            };


            secondButton.Clicked += async (sendernav, args) =>
                await Navigation.PushAsync(new TabPage());

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, labelBethMike, mike, secondButton}

            };

            this.Content = stackLayout;
        }

        public bool TabPageDataBound { get; }
    }
}
