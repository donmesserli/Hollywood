using System;
using Xamarin.Forms;

namespace Hollywood.Model
{
	public class Actor
	{
		public Actor ()
		{
		}

		public const string NamePropertyName = "Name";
		public string Name { get; set; }

		public const string BirthDatePropertyName = "BirthDate";
		public DateTime BirthDate { get; set; }

		public string ImageFile { get; set; }

		public const string ImagePropertyName = "ImageName";
		public ImageSource ImageName { 
			get {
				return ImageSource.FromFile (ImageFile);
			}
		}

		public const string FemalePropertyName = "Female";
		public Boolean Female { get; set; }
	}
}

