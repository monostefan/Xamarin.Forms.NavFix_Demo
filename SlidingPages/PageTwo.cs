using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlidingPages
{
	public class PageTwo : ContentPage
	{
		public PageTwo()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			BackgroundColor = Color.FromHex("#e040fb");
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Brace for pop!",
						TextColor = Color.White,
						FontSize = 20,
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			await Task.Delay(2000);
			await Navigation.PopAsync();
		}
	}
}


