using System;
using System.Collections.Generic;
using Hollywood.Model;
using System.Linq;

namespace Hollywood.ViewModels
{
	public class MovieListViewModel
	{
		public List<Movie> movies;

		public MovieListViewModel ()
		{
			movies = new List<Movie> ();

			movies.Add (new Movie () {
				Title = "Apocalypse Now",
				Year = 1979,
				Director = "Francis Ford Coppola",
				ImageFile = "Apocalypse.jpg",
				Synopsis = "During the U.S.-Viet Nam War, Captain Willard is sent on a dangerous mission into Cambodia to assassinate a renegade colonel who has set himself up as a god among a local tribe."
			});

			movies.Add (new Movie () {
				Title = "A Clockwork Orange",
				Year = 1971,
				Director = "Stanley Kubrick",
				ImageFile = "Clockwork.jpg",
				Synopsis = "In future Britain, charismatic delinquent Alex DeLarge is jailed and volunteers for an experimental aversion therapy developed by the government in an effort to solve society's crime problem - but not all goes according to plan."
			});

			movies.Add (new Movie () {
				Title = "Trainspotting",
				Year = 1996,
				Director = "Danny Boyle",
				ImageFile = "Trainspotting.jpg",
				Synopsis = "Renton, deeply immersed in the Edinburgh drug scene, tries to clean up and get out, despite the allure of the drugs and influence of friends."
			});

			movies.Add (new Movie () {
				Title = "Brave",
				Year = 2012,
				Director = "Mark Andrews",
				ImageFile = "Brave.jpg",
				Synopsis = "Determined to make her own path in life, Princess Merida defies a custom that brings chaos to her kingdom. Granted one wish, Merida must rely on her bravery and her archery skills to undo a beastly curse."
			});

			movies.Add (new Movie () {
				Title = "Stranger Than Fiction",
				Year = 2006,
				Director = "Marc Foster",
				ImageFile = "Fiction.jpg",
				Synopsis = "An IRS auditor suddenly finds himself the subject of narration only he can hear: narration that begins to affect his entire life, from his work, to his love-interest, to his death."
			});

			movies.Add (new Movie () {
				Title = "The Last Samurai",
				Year = 2003,
				Director = "Edward Zwick",
				ImageFile = "Samurai.jpg",
				Synopsis = "An American military advisor embraces the Samurai culture he was hired to destroy after he is captured in battle."
			});

			movies.Add (new Movie () {
				Title = "Top Gun",
				Year = 1986,
				Director = "Tony Scott",
				ImageFile = "TopGun.jpg",
				Synopsis = "As students at the Navy's elite fighter weapons school compete to be best in the class, one daring young flyer learns a few things from a civilian instructor that are not taught in the classroom."
			});

			movies.Add (new Movie () {
				Title = "Heat",
				Year = 1995,
				Director = "Michael Mann",
				ImageFile = "Heat.jpg",
				Synopsis = "A group of professional bank robbers start to feel the heat from police when they unknowingly leave a clue at their latest heist."
			});

			movies.Add (new Movie () {
				Title = "The Deer Hunter",
				Year = 1978,
				Director = "Michael Cimino",
				ImageFile = "DeerHunter.jpg",
				Synopsis = "An in-depth examination of the ways in which the Vietnam War disrupts and impacts the lives of people in a small industrial town in Pennsylvania."
			});

			movies.Add (new Movie () {
				Title = "The Italian Job",
				Year = 2003,
				Director = "F. Gary Gray",
				ImageFile = "ItalianJob.jpg",
				Synopsis = "After being betrayed and left for dead in Italy, Charlie Croker and his team plan an elaborate gold heist against their former ally."
			});

			movies = movies.OrderBy(m=>m.Title).ToList();
		}
	}
}

