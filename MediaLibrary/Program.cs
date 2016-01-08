using System;
using System.Collections;

namespace MediaLibrary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string repeat = "b";
			ArrayList mediaObjects = new ArrayList();
			MediaFactory mediaFactory = new MediaFactory();

			while (repeat != "no") {
				string mediaType = "";
				string seriesName = "";
				int mediaChoice = 0;
				string yearOfRelease = "";
				int yearReleased = 0;

				Console.WriteLine("1 - Book");
				Console.WriteLine("2 - Movie");
				Console.WriteLine("3 - Music");
				Console.WriteLine("");

				while (mediaChoice < 1 || mediaChoice > 3) {
					Console.Write("Select a number corresponding to one of the three options above: ");
					try {
						mediaChoice = Convert.ToInt32(Console.ReadLine());
					}
					catch (FormatException e) {
						Console.WriteLine(e);
						Environment.Exit(1);
					}

					if (mediaChoice == 1) {
						mediaType = "BOOK";
					}
					else if (mediaChoice == 2) {
						mediaType = "MOVIE";
					}
					else if (mediaChoice == 3) {
						mediaType = "MUSIC";
					}
				}

				Media newMedia = mediaFactory.get_Media(mediaType);

				Console.Write("Title of new book, movie, or CD: ");
				string title = Console.ReadLine();
				title = title.Trim ();
				newMedia.Title = title;
				Console.Write("Year of release: ");
				yearOfRelease = Console.ReadLine();
				yearOfRelease = yearOfRelease.Trim ();
				while (yearOfRelease.Length != 4) {
					Console.WriteLine("You need to enter a year four using four digits.");
					Console.Write("Year of release: ");
					yearOfRelease = Console.ReadLine();
					yearOfRelease = yearOfRelease.Trim ();
					yearReleased = Convert.ToInt32(yearOfRelease);
				}
				yearReleased = Convert.ToInt32(yearOfRelease);
				newMedia.ReleaseYear = yearReleased;
				Console.Write("First (or only) name of author, artist, or lead actor: ");
				string firstNameAlpha = Console.ReadLine();
				firstNameAlpha = firstNameAlpha.Trim();
				string firstName = char.ToUpper(firstNameAlpha[0]) + firstNameAlpha.Substring(1);
				Console.Write("Last name of author, artist, or lead actor. Type \"none\" if person goes by Prince, Sting, etc.: ");
				string lastNameAlpha = Console.ReadLine();
				lastNameAlpha = lastNameAlpha.Trim();
				string lastName = char.ToUpper(lastNameAlpha[0]) + lastNameAlpha.Substring(1);
				if (lastName == "None") {
					newMedia.setKeyPlayer(firstName);
				}
				else {
					newMedia.setKeyPlayer(firstName, lastName);
				}
				Console.Write("Is this part of a series? Answer yes or no. ");
				String partOfSeries = Console.ReadLine();
				partOfSeries = partOfSeries.Trim();
				if (partOfSeries == "no") {
					seriesName = "N/A";
				}
				else if (partOfSeries == "yes"){
					Console.Write("Enter the series' name: ");
					seriesName = Console.ReadLine();
					seriesName = seriesName.Trim();
				}
				else {
					Console.WriteLine("That really isn't valid a response. You need to re-effort from the beginning.");
					Environment.Exit(0);
				}
				newMedia.Series = seriesName;
				newMedia.SelectGenre();
				newMedia.SelectFormat();

				mediaObjects.Add(newMedia);

				Console.Write("Add more entries? Answer yes or no. ");
				repeat = Console.ReadLine();
				repeat = repeat.Trim();
				repeat = repeat.ToLower();
			}
			foreach (Media item in mediaObjects) {
				Console.WriteLine("");
				Console.WriteLine(item.Title);
				Console.WriteLine(item.ReleaseYear);
				Console.WriteLine(item.Genre);
				Console.WriteLine(item.Format);
				Console.WriteLine(item.KeyPlayer);
				Console.WriteLine(item.Series);
				Console.WriteLine("");
			}
		}
	}
}
