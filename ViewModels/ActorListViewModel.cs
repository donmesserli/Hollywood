using System;
using System.Collections.Generic;
using Hollywood.Model;
using System.Linq;

namespace Hollywood.ViewModels
{
	public class ActorListViewModel
	{
		public List<Actor> actors;

		public ActorListViewModel ()
		{
			actors = new List<Actor> ();

			actors.Add (new Actor () {
				Name = "Mark Wahlberg",
				BirthDate = new DateTime(1971, 6, 5),
				ImageFile = "MarkWahlberg.jpg"
			});

			actors.Add (new Actor () {
				Name = "Jason Statham",
				BirthDate = new DateTime(1967, 7, 26),
				ImageFile = "JasonStatham.jpg"
			});

			actors.Add (new Actor () {
				Name = "Michelle Rodriguez",
				BirthDate = new DateTime(1978, 7, 12),
				ImageFile = "MichelleRodriguez.jpg",
				Female = true
			});

			actors.Add (new Actor () {
				Name = "Giovanni Ribisi",
				BirthDate = new DateTime(1974, 12, 17),
				ImageFile = "GiovanniRibisi.jpg"
			});

			actors.Add (new Actor () {
				Name = "Hugh Laurie",
				BirthDate = new DateTime(1959, 6, 11),
				ImageFile = "HughLaurie.jpg"
			});

			actors.Add (new Actor () {
				Name = "Paul Rudd",
				BirthDate = new DateTime(1969, 4, 6),
				ImageFile = "PaulRudd.jpg"
			});

			actors.Add (new Actor () {
				Name = "Kate Beckinsale",
				BirthDate = new DateTime(1973, 7, 26),
				ImageFile = "KateBeckinsale.jpg",
				Female = true
			});

			actors.Add (new Actor () {
				Name = "Ian Holm",
				BirthDate = new DateTime(1931, 9, 12),
				ImageFile = "IanHolm.jpg"
			});

			actors.Add (new Actor () {
				Name = "Jared Leto",
				BirthDate = new DateTime(1971, 12, 26),
				ImageFile = "JaredLeto.jpg"
			});

			actors.Add (new Actor () {
				Name = "Griffin Dunne",
				BirthDate = new DateTime(1955, 6, 8),
				ImageFile = "GriffinDunne.jpg"
			});

			actors = actors.OrderBy(a=>a.Name).ToList();
		}
	}
}

