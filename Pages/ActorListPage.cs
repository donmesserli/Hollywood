using System;
using Xamarin.Forms;
using Hollywood.ViewModels;
using Hollywood.Model;

namespace Hollywood.Pages
{
	public class ActorListPage : ContentPage
	{
		private ListView listView;
		private ActorListViewModel viewModel;

		public ActorListPage ()
		{
			viewModel = new ActorListViewModel ();

			Title = "Actors";

			listView = new ListView ();

			var cell = new DataTemplate(typeof(ImageCell));
			cell.SetBinding (ImageCell.TextProperty, new Binding (Actor.NamePropertyName, BindingMode.OneWay));
			cell.SetBinding (ImageCell.ImageSourceProperty, new Binding (Actor.ImagePropertyName, BindingMode.OneWay));
			cell.SetBinding (ImageCell.DetailProperty, new Binding (path: Actor.BirthDatePropertyName, stringFormat: "{0:MM/dd/yyyy}"));
			listView.ItemTemplate = cell;

			listView.ItemsSource = viewModel.actors;

			listView.ItemTapped += (sender, args) =>
			{
				var actor = args.Item as Actor;
				if (actor == null)
					return;

				Navigation.PushAsync(new ActorDetailPage(actor));
				listView.SelectedItem = null;
			};
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}
	}
}

