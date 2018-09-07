using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    class HomePage : MainPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, 5, 10, 5);

            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });    
           
            this.Title = "Home Page";
            this.Content = new TableView

            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
               new  TableSection ("BETH'S FAMILY:")
                {

                    new TextCell
                    {
                        Text = "My Kids",
                        TextColor = Color.Blue,
                        Command = navigateCommand,
                        CommandParameter = typeof(ModalPage)
                    },

                    new TextCell
                    {
                        Text = "My Fiance",
                        TextColor = Color.Red,
                        Command = navigateCommand,
                        CommandParameter = typeof(SecondPage)
                    },

                    new TextCell
                    {
                        Text = "My Zoo",
                        TextColor = Color.Green,
                        Command = navigateCommand,
                        CommandParameter = typeof(TabPage)
                    },

                    new TextCell
                    {
                        Text = "Me",
                        TextColor = Color.DarkViolet,
                        Command = navigateCommand,
                        CommandParameter = typeof(ThirdPage)
                    },
                }
                }

            };

            StackLayout stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Start,
 
            };
          
        }
    }
}

