using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trippp.View;
using Xamarin.Forms;

namespace Trippp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = Start();
		}


        private NavigationPage Start()
        {
            var page = new NavigationPage(new StartPage())
            {
                Title = "Avgångar",
                Icon = null
            };
            return page;
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
