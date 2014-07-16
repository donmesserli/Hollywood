using System;
using Xamarin.Forms;
using Hollywood.Services;

namespace Hollywood.Pages
{
	public class MainPage : TabbedPage
	{
		private const string StartPageKey = "StartPage";

		NavigationPage movies;
		NavigationPage actors;

		public MainPage ()
		{
			String page = DependencyService.Get<ISettings>().GetValueOrDefault<string>(StartPageKey, "Movies");

			movies = new NavigationPage (new MovieListPage ()) { Title = "Movies", Icon = "movie.png" };
			actors = new NavigationPage (new ActorListPage ()) { Title = "Actors", Icon = "actor.png" };

			Children.Add(
				movies
			);

			Children.Add(
				actors
			);

			this.CurrentPage = PageFromName (page);
		}

		protected override void OnCurrentPageChanged ()
		{
			// Write to settings
			DependencyService.Get<ISettings> ().AddOrUpdateValue (StartPageKey, this.CurrentPage.Title);
			DependencyService.Get<ISettings> ().Save ();

			base.OnCurrentPageChanged ();
		}

		private NavigationPage PageFromName (string name)
		{
			if (name != null && name.Equals ("Actors")) {
				return actors;
			}

			return movies;			
		}

	}
}

