using System;
using Xamarin.Forms;
using Hollywood.Model;

namespace Hollywood.Pages
{
	public class MovieDetailPage : ContentPage
	{
		public MovieDetailPage (Movie movie)
		{
			Title = "Movie Detail";

			BindingContext = movie;
						 
			Label nameLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize(Device.OnPlatform(22, 24, 24)),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				WidthRequest = 250,
				HeightRequest = 50,
			};
			nameLabel.SetBinding (Label.TextProperty, Movie.TitlePropertyName);

			Image picture = new Image
			{
				WidthRequest = 250,
				HeightRequest = 200
			};
			picture.SetBinding (Image.SourceProperty, Movie.ImagePropertyName);

			Label yearPromptLabel = new Label
			{
				Text = "Year: ",
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 70,
				HeightRequest = 40,
			};

			Label yearLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 200,
				HeightRequest = 40,
			};
			yearLabel.SetBinding (Label.TextProperty, Movie.YearPropertyName);

			StackLayout year = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { 
					yearPromptLabel,
					yearLabel
				}
			};

			Label dirPromptLabel = new Label
			{
				Text = "Director: ",
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 70,
				HeightRequest = 40,
			};

			Label dirLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 200,
				HeightRequest = 30,
			};
			dirLabel.SetBinding (Label.TextProperty, Movie.DirectorPropertyName);

			Label synopsisPromptLabel = new Label
			{
				Text = "Synopsis: ",
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 70,
				HeightRequest = 30,
			};

			Label synopsisLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Start,
				WidthRequest = 250,
				HeightRequest = 200,
			};
			synopsisLabel.SetBinding (Label.TextProperty, Movie.SynopsisPropertyName);

			StackLayout dir = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { 
					dirPromptLabel,
					dirLabel
				}
			};

			Content = new StackLayout
			{
				Spacing = 10,
				HorizontalOptions = LayoutOptions.Center,
				Children = { 
					nameLabel,
					picture,
					year,
					dir,
					synopsisPromptLabel,
					synopsisLabel
				}
			};
		}
	}
}

