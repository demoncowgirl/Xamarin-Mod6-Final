using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class ThirdPage : ContentPage
    {
        private Button thirdButton;

        public ThirdPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "Me";

            Image beth = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.gusmanopic.png"),
                HeightRequest = 400,
                WidthRequest = 400,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            Label homeLabel = new Label
            {
                Text = "Me in 1983." +
                "Pasadena, CA." +
                "Photo by Gusmano Cesaretti.",
                FontSize = 25,
                TextColor = Color.Black
            };

            thirdButton = new Button
            {
                Text = "Go Back Home"
            };

            thirdButton.Clicked += async (sendernav, args) =>
                await Navigation.PopAsync();


            var stackLayout = new StackLayout
            {
                Children = { beth, homeLabel, thirdButton }
            };

            this.Content = stackLayout;
        }


    }
}
