using System;
using Xamarin.Forms;

namespace SlidingPages
{
	public class App : Application
	{
		public App()
		{

			var navPage = new NavigationPage(new PageOne());

			// Enabling this Flag prevents the app from crashing when sent to the background
			navPage.AllowStateLoss = true;

			MainPage = navPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
