using System;
using Xamarin.Forms;
using Hollywood.Model;

namespace Hollywood.Pages
{
	public class MovieViewCell : ViewCell
	{
		protected Label _TitleLabel = null;
		protected Label _DetailsLabel = null;
		protected Image _Image = null;
		protected Image _Rating = null;

		public ImageSource ImageSource
		{
			set
			{
				_Image.Source = value;
			}
		}

		public string Title
		{
			set
			{
				_TitleLabel.Text = value;
			}
		}

		public string Details
		{
			set
			{
				_DetailsLabel.Text = value;
			}
		}

		public ImageSource RatingSource
		{
			set
			{
				_Rating.Source = value;
			}
		}

		public MovieViewCell ()
		{
			_TitleLabel = new Label () {
				Text = "Title",
				Font = Font.SystemFontOfSize (18),
				//TextColor = Color.Black,
				LineBreakMode = LineBreakMode.TailTruncation,
				HorizontalOptions = LayoutOptions.Start,
				WidthRequest = 200,
				HeightRequest = 44
				//BackgroundColor = Xamarin.Forms.Color.Aqua
			};

			_DetailsLabel = new Label () {
				Text = "Comment goes here",
				//Font = Font.SystemFontOfSize (12),
				Font = Font.OfSize("HelveticaNeue-Light", 13),
				TextColor = Color.Gray,
				LineBreakMode = LineBreakMode.WordWrap,
				HorizontalOptions = LayoutOptions.Start,
				//BackgroundColor = Xamarin.Forms.Color.Red
			};

			_Image = new Image () 
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			_Rating = new Image () 
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			View = new StackLayout ()
			{
				Padding = new Thickness( 10, 0, 10, 0 ),
				Orientation = StackOrientation.Horizontal,
				Children = 
				{
					_Image,
					new StackLayout () 
					{
						Spacing = 0,
						Padding = new Thickness( 10, 5, 10, 10 ),
						Orientation = StackOrientation.Vertical,
						Children = 
						{
							_TitleLabel,
							_DetailsLabel
						}
					}
				}
			};

			_TitleLabel.SetBinding(Label.TextProperty, Movie.TitlePropertyName);
			_Image.SetBinding (Image.SourceProperty, new Binding (Movie.ImagePropertyName, BindingMode.OneWay));
			_DetailsLabel.SetBinding (Label.TextProperty, new Binding (Movie.YearPropertyName, BindingMode.OneWay));
			//_Rating.SetBinding (Image.SourceProperty, new Binding (Movie.RatingPropertyName, BindingMode.OneWay));
		}
	}
}

