using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class DogPage : ContentPage
    {
        public DogPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Dog";
            Label ellie = new Label
            {
                Text = ("This is my dog, Ellie Mae."),
                FontSize = 25,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Image ellieMae = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.ellie.png"),
                HeightRequest = 400,
                WidthRequest = 400,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };
            var stackLayout = new StackLayout
            {
                Children = { ellie, ellieMae }

            };

            this.Content = stackLayout;
        }
    }
}
