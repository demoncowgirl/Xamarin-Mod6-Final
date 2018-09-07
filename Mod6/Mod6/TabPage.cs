using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mod6
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {

                this.Children.Add(new DogPage());
                this.Children.Add(new CatPage());
                this.Children.Add(new ParrotPage());
            
        }

    }
}
