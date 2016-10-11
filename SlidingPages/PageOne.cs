using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlidingPages
{
	public class PageOne : ContentPage
	{
		public PageOne()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			BackgroundColor = Color.FromHex("#2196f3");
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Going to page two any moment",
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
			await Navigation.PushAsync(new PageTwo());
		}
	}
}

