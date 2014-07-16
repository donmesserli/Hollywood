using System;
using Xamarin.Forms;

namespace Hollywood.Model
{
	public class Movie
	{
		public Movie ()
		{
		}

		public const string TitlePropertyName = "Title";
		public string Title { get; set; }

		public const string YearPropertyName = "Year";
		public int Year { get; set; }

		public const string DirectorPropertyName = "Director";
		public string Director { get; set; }

		public const string SynopsisPropertyName = "Synopsis";
		public string Synopsis { get; set; }

		public string ImageFile { get; set; }

		public const string ImagePropertyName = "ImageName";
		public ImageSource ImageName { 
			get {
				return ImageSource.FromFile (ImageFile);
			}
		}

		public Boolean IsGood { get; set; }

		public const string RatingPropertyName = "RatingImage";
		public ImageSource RatingImage {
			get {
				if (IsGood) {
					return ImageSource.FromFile ("up.png");
				} else {
					return ImageSource.FromFile ("down.png");
				}
			}
		}
	}
}

