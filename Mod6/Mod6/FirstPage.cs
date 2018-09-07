
using Xamarin.Forms;

namespace Mod6
{
    class FirstPage : ContentPage
    {
        Button homeButton;
        public FirstPage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Title = "My Kids";

            Label homeLabel = new Label
            {
                Text = "My Kids",
                FontSize = 40,
                TextColor = Color.DarkSlateBlue
            };

            Label labelIan = new Label
            {
                Text = "This is my oldest son, Ian, and his dog, Pip. Ian is in the USAF",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Image ian = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.ianandpip.jpg"),
                HeightRequest = 225,
                WidthRequest = 225,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label labelAaron = new Label
            {
                Text = "This is my youngest son, Aaron. He is a finance major at NDSU. This is me and Aaron.",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Image aaron = new Image
            {
                Source = ImageSource.FromResource("Mod6.Resources.aaron.jpg"),
                HeightRequest = 225,
                WidthRequest = 225,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            homeButton = new Button
            {
                Text = "Main Menu",
                BackgroundColor = Color.Silver,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.End
            };

            homeButton.Clicked += async (sender, args) =>
                await Navigation.PopAsync();
            

            var stackLayout = new StackLayout
            {
                Children = { homeLabel, labelIan, ian, labelAaron, aaron, homeButton },
            };

           this.Content = stackLayout;


        }

    }
}
