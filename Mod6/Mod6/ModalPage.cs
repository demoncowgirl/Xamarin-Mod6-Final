using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Mod6
{
    class ModalPage : ContentPage
    {
        Button firstButton;

        public ModalPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Kids";

            Label homeLabel = new Label
            {
                Text = "To see photos of my boys.....",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                FontSize = 40
            };


            Button firstButton = new Button
             {
                 Text = "Click Here"
             };

             firstButton.Clicked += async (sendernav, args) =>
                 await Navigation.PushAsync(new FirstPage(), false);

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, firstButton }

            };

            this.Content = stackLayout;
        }

    }
}
