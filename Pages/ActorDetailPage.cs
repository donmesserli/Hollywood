using System;
using Xamarin.Forms;
using Hollywood.Model;

namespace Hollywood.Pages
{
	public class ActorDetailPage : ContentPage
	{
		public ActorDetailPage (Actor actor)
		{
			Title = "Actor Detail";

			BindingContext = actor;

			Label nameLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize (22),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				WidthRequest = 250,
				HeightRequest = 30,
			};
			nameLabel.SetBinding (Label.TextProperty, Actor.NamePropertyName);

			Image picture = new Image
			{
				WidthRequest = 250,
				HeightRequest = 300
			};
			picture.SetBinding (Image.SourceProperty, Actor.ImagePropertyName);

			Label bornLabel = new Label
			{
				Text = "Born: ",
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 50,
				HeightRequest = 30,
			};

			Label dobLabel = new Label
			{
				Text = string.Empty,
				Font = Font.SystemFontOfSize (16),
				TextColor = Xamarin.Forms.Color.Black,
				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				WidthRequest = 100,
				HeightRequest = 30,
			};
			dobLabel.SetBinding (Label.TextProperty, new Binding(path: Actor.BirthDatePropertyName, stringFormat: "{0:MM/dd/yyyy}"));

			StackLayout dob = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Center,
				Children = { 
					bornLabel,
					dobLabel
				}
			};

			Button callButton = new Button {
				Text = "Call Her",
				Font = Font.SystemFontOfSize (18),

			};
			callButton.SetBinding (View.IsVisibleProperty, Actor.FemalePropertyName);
			callButton.Clicked += (object sender, EventArgs e) => {
				DisplayAlert ("Damn!", "She didn't answer.", "OK");
			};

			Content = new StackLayout
			{
				Spacing = 10,
				HorizontalOptions = LayoutOptions.Center,
				Children = { 
					nameLabel,
					picture,
					dob,
					callButton
				}
			};

		}
	}
}

