using System;
using Xamarin.Forms;
using Hollywood.ViewModels;
using Hollywood.Model;

namespace Hollywood.Pages
{
	public class MovieListPage : ContentPage
	{
		private ListView listView;
		private MovieListViewModel viewModel;

		public MovieListPage ()
		{
			viewModel = new MovieListViewModel ();

			Title = "Movies";

			listView = new ListView ();

			#if __IOS__
			var cell = new DataTemplate(typeof(MovieViewCell));
			//cell.SetBinding (ImageCell.TextProperty, new Binding (Movie.TitlePropertyName, BindingMode.OneWay));
			//cell.SetBinding (ImageCell.ImageSourceProperty, new Binding (Movie.ImagePropertyName, BindingMode.OneWay));
			//cell.SetBinding (ImageCell.DetailProperty, new Binding (Movie.YearPropertyName, BindingMode.OneWay));
			listView.ItemTemplate = cell;
			#else
			var cell = new DataTemplate(typeof(ImageCell));
			cell.SetBinding (ImageCell.TextProperty, new Binding (Movie.TitlePropertyName, BindingMode.OneWay));
			cell.SetBinding (ImageCell.ImageSourceProperty, new Binding (Movie.ImagePropertyName, BindingMode.OneWay));
			cell.SetBinding (ImageCell.DetailProperty, new Binding (Movie.YearPropertyName, BindingMode.OneWay));
			listView.ItemTemplate = cell;
			#endif

			listView.ItemsSource = viewModel.movies;

			listView.ItemTapped += (sender, args) =>
			{
				var movie = args.Item as Movie;
				if (movie == null)
					return;

				Navigation.PushAsync(new MovieDetailPage(movie));
				listView.SelectedItem = null;
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}
	}
}

