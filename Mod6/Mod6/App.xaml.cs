using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Mod6
{
	public partial class App : Application
	{
		public App ()
		{
           var page = new HomePage();
            MainPage = new NavigationPage(page);

           //MainPage = new Mod6.TabPageDatabound();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
