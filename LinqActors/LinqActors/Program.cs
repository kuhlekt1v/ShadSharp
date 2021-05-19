using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqActors
{
    class Program
    {
        static void Main(string [] args)
        {
			// list of actors and their earnings

			string data = @"[
			[""Harrison Ford"", 4871.7, 41, 118.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Samuel L. Jackson"", 4772.8, 69, 69.2, ""The Avengers"", 623.4],
			[""Morgan Freeman"", 4468.3, 61, 73.3, ""The Dark Knight"", 534.9],
			[""Tom Hanks"", 4340.8, 44, 98.7, ""Toy Story 3"", 415],
			[""Robert Downey Jr."", 3947.3, 53, 74.5, ""The Avengers"", 623.4],
			[""Eddie Murphy"", 3810.4, 38, 100.3, ""Shrek 2"", 441.2],
			[""Tom Cruise"", 3587.2, 36, 99.6, ""War of the Worlds"", 234.3],
			[""Johnny Depp"", 3368.6, 45, 74.9, ""Dead Man's Chest"", 423.3],
			[""Michael Caine"", 3351.5, 58, 57.8, ""The Dark Knight"", 534.9],
			[""Scarlett Johansson"", 3341.2, 37, 90.3, ""The Avengers"", 623.4],
			[""Gary Oldman"", 3294, 38, 86.7, ""The Dark Knight"", 534.9],
			[""Robin Williams"", 3279.3, 49, 66.9, ""Night at the Museum"", 250.9],
			[""Bruce Willis"", 3189.4, 60, 53.2, ""Sixth Sense"", 293.5],
			[""Stellan Skarsgard"", 3175, 43, 73.8, ""The Avengers"", 623.4],
			[""Anthony Daniels"", 3162.9, 7, 451.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Ian McKellen"", 3150.4, 31, 101.6, ""Return of the King"", 377.8],
			[""Will Smith"", 3149.1, 24, 131.2, ""Independence Day"", 306.2],
			[""Stanley Tucci"", 3123.9, 50, 62.5, ""Catching Fire"", 424.7],
			[""Matt Damon"", 3107.3, 39, 79.7, ""The Martian"", 228.4],
			[""Robert DeNiro"", 3081.3, 79, 39, ""Meet the Fockers"", 279.3],
			[""Cameron Diaz"", 3031.7, 34, 89.2, ""Shrek 2"", 441.2],
			[""Liam Neeson"", 2942.7, 63, 46.7, ""The Phantom Menace"", 474.5],
			[""Andy Serkis"", 2890.6, 23, 125.7, ""Star Wars: The Force Awakens"", 936.7],
			[""Don Cheadle"", 2885.4, 34, 84.9, ""Avengers: Age of Ultron"", 459],
			[""Ben Stiller"", 2827, 37, 76.4, ""Meet the Fockers"", 279.3],
			[""Helena Bonham Carter"", 2822, 36, 78.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Orlando Bloom"", 2815.8, 17, 165.6, ""Dead Man's Chest"", 423.3],
			[""Woody Harrelson"", 2815.8, 50, 56.3, ""Catching Fire"", 424.7],
			[""Cate Blanchett"", 2802.6, 39, 71.9, ""Return of the King"", 377.8],
			[""Julia Roberts"", 2735.3, 42, 65.1, ""Ocean's Eleven"", 183.4],
			[""Elizabeth Banks"", 2726.3, 35, 77.9, ""Catching Fire"", 424.7],
			[""Ralph Fiennes"", 2715.3, 36, 75.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Emma Watson"", 2681.9, 17, 157.8, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Tommy Lee Jones"", 2681.3, 46, 58.3, ""Men in Black"", 250.7],
			[""Brad Pitt"", 2680.9, 40, 67, ""World War Z"", 202.4],
			[""Adam Sandler"", 2661, 32, 83.2, ""Hotel Transylvania 2"", 169.7],
			[""Daniel Radcliffe"", 2634.4, 17, 155, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Jonah Hill"", 2605.1, 29, 89.8, ""The LEGO Movie"", 257.8],
			[""Owen Wilson"", 2602.3, 39, 66.7, ""Night at the Museum"", 250.9],
			[""Idris Elba"", 2580.6, 26, 99.3, ""Avengers: Age of Ultron"", 459],
			[""Bradley Cooper"", 2557.7, 25, 102.3, ""American Sniper"", 350.1],
			[""Mark Wahlberg"", 2549.8, 36, 70.8, ""Transformers 4"", 245.4],
			[""Jim Carrey"", 2545.2, 27, 94.3, ""The Grinch"", 260],
			[""Dustin Hoffman"", 2522.1, 43, 58.7, ""Meet the Fockers"", 279.3],
			[""Leonardo DiCaprio"", 2518.3, 25, 100.7, ""Titanic"", 658.7],
			[""Jeremy Renner"", 2500.3, 21, 119.1, ""The Avengers"", 623.4],
			[""Philip Seymour Hoffman"", 2463.7, 40, 61.6, ""Catching Fire"", 424.7],
			[""Sandra Bullock"", 2462.6, 35, 70.4, ""Minions"", 336],
			[""Chris Evans"", 2457.8, 23, 106.9, ""The Avengers"", 623.4],
			[""Anne Hathaway"", 2416.5, 25, 96.7, ""The Dark Knight Rises"", 448.1]
		]";

			List<Actor> actorList = new List<Actor>();

			JArray a = JArray.Parse(data);

			foreach(var item in a)
            {
				Actor actor = new Actor
				{
					Name = (string)item [0],
					TotalGross = (decimal)item [1],
					MovieCount = (int)item [2],
					AveragePerMovie = (decimal)item [3],
					TopMovie = (string)item [4],
					TopMovieGross = (decimal)item [5]
				};
				actorList.Add(actor);

            }

			Console.WriteLine("Actors count = " + actorList.Count);

            // Show only the wealthiest actors
            // First use standard for loops. Not LINQ
			List<Actor> richActors = new List<Actor>();
            foreach (var item in actorList)
            {
				if(item.TotalGross > 4000)
                {
					richActors.Add(item);
                }
            }

			Console.WriteLine("Rich actors that earned more than $400 million");
            Console.WriteLine(printList(richActors));
			Console.ReadLine();

			// Using LINQ
			var richActors2 = from actor in actorList
							  where actor.TotalGross > 4000
							  select actor;

			Console.WriteLine("Rich actors that earned more than $400 million");
			Console.WriteLine(printList(richActors2));
			Console.ReadLine();

			// Using Lambda
			var richActors3 = actorList.Where(x => x.TotalGross > 4000);

			Console.WriteLine("Rich actors that earned more than $400 million");
			Console.WriteLine(printList(richActors3));
			Console.ReadLine();

			// Show actors that star in an even number of movies
			var actorsWithEvenNumber = new List<Actor>();

			// STANDARD FOR
            foreach (var item in actorList)
            {
				if(item.MovieCount % 2 == 0)
                {
					actorsWithEvenNumber.Add(
						new Actor
						{
							Name = item.Name,
							MovieCount = item.MovieCount
						});
                }
            }

            Console.WriteLine("Actors with even # of movies..");
			Console.WriteLine(printList(actorsWithEvenNumber));
			Console.ReadLine();

			// LINQ
			var actorsWithEven2 = from actor in actorList
								  where actor.MovieCount % 2 == 0
								  select new Actor
								  {
									  Name = actor.Name,
									  MovieCount = actor.MovieCount
								  };

			Console.WriteLine("Actors with even # of movies..");
			Console.WriteLine(printList(actorsWithEven2));
			Console.ReadLine();

			// LAMBDA
			var actorsWithEven3 = actorList.Where(
				a => a.MovieCount % 2 == 0)
				.Select(x => new Actor
				{
					Name = x.Name,
					MovieCount = x.MovieCount
				});

			Console.WriteLine("Actors with even # of movies..");
			Console.WriteLine(printList(actorsWithEven3));
			Console.ReadLine();

			// Example 3 - Star Wars Actors
			var starWarsActors = new List<Actor>();

			// FOR EACH
			foreach (var item in actorList)
			{
				if (item.TopMovie.Contains("Star Wars"))
				{
					starWarsActors.Add(
						new Actor
						{
							Name = item.Name,
							TopMovie = item.TopMovie
                        });
				}
			}

			Console.WriteLine("Actors who starred in Star Wars");
			Console.WriteLine(printList(starWarsActors));
			Console.ReadLine();

			// LINQ
			var starWarsActors2 = from actor in actorList
								  where actor.TopMovie.Contains("Star Wars")
								  select new Actor
								  {
									  Name = actor.Name,
									  TopMovie = actor.TopMovie
								  };

			Console.WriteLine("Actors who starred in Star Wars");
			Console.WriteLine(printList(starWarsActors2));
			Console.ReadLine();

			// LAMBDA
			var starWarsActors3 = actorList
				.Where(a => a.TopMovie.Contains("Star Wars"))
				.Select(x => new Actor
				{
					Name = x.Name,
					TopMovie = x.TopMovie
				});

			Console.WriteLine("Actors who starred in Star Wars");
			Console.WriteLine(printList(starWarsActors3));
			Console.ReadLine();

			// Grouping
			var groupByMovies = from actor in actorList
								where actor.TopMovie.Contains("S")
							   group actor by actor.TopMovie into newGroup
							   orderby newGroup.Key
							   from actorInGroup in newGroup
							   select new Actor
							   {
								   Name = actorInGroup.Name,
								   TopMovie = actorInGroup.TopMovie
							   };

			Console.WriteLine("Actors grouped by top movie");
			Console.WriteLine(printList(groupByMovies));
			Console.ReadLine();

			var groupByMovies2 = actorList.GroupBy(a => a.TopMovie)
				.OrderBy(b => b.Key)
				.SelectMany(c => c)
				.Select(d => new Actor
				{
					Name = d.Name,
					TopMovie = d.TopMovie
				});

			Console.WriteLine("Actors grouped by top movie");
			Console.WriteLine(printList(groupByMovies2));
			Console.ReadLine();

		}




        private static bool printList(IEnumerable<Actor> richActors)
        {
            foreach (var item in richActors)
            {
				Console.WriteLine(item);
            }
			return true;
        }
    }
}
