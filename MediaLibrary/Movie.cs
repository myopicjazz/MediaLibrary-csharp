using System;

namespace MediaLibrary
{
	public class Movie : Media
	{
			private string _title;
			private int _releaseYear;
			private string _genre;
			private string _format;
			private string _keyPlayer;
			private string _series;

			public Movie() {}

			public string Title { get; set; }
			public int ReleaseYear { get; set; }
			public string Genre { get; set; }
			public string Format { get; set; }
			public string Series { get; set; }
			public string KeyPlayer
			{
				get { return _keyPlayer; }
			}
			public void setKeyPlayer (string firstName)
			{
				_keyPlayer = firstName;
			}
			public void setKeyPlayer (string firstName, string lastName)
			{
				_keyPlayer = lastName + ", " + firstName;
			}

			public void SelectGenre() {
				int genreNumber = 0;
				String musicGenre = "";
				Console.WriteLine("1 - Fantasy");
				Console.WriteLine("2 - Science Fiction");
				Console.WriteLine("3 - Mystery");
				Console.WriteLine("4 - Romance");
				Console.WriteLine("5 - Classics");
				Console.WriteLine("6 - Horror");
				Console.WriteLine("7 - Action/Adventure");
				Console.WriteLine("8 - Documentary");
				Console.WriteLine("");
				Console.Write("Choose the number of one of the genres above: ");
				try {
				genreNumber = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException e) {
					Console.WriteLine(e);
				}

				switch (genreNumber){
				case 1:
					musicGenre = "Fantasy";
					break;
				case 2:
					musicGenre = "Science Fiction";
					break;
				case 3:
					musicGenre = "Mystery";
					break;
				case 4:
					musicGenre = "Romance";
					break;
				case 5:
					musicGenre = "Classics";
					break;
				case 6:
					musicGenre = "Horror";
					break;
				case 7:
					musicGenre = "Action/Adventure";
					break;
				case 8:
					musicGenre = "Documentary";
					break;
				default:
					musicGenre = "Other";
					break;
				}
				Genre = musicGenre;
			}

			public void SelectFormat() {
				int formatNumber = 0;
				String musicFormat = "";
				Console.WriteLine("1 - DVD");
				Console.WriteLine("2 - BluRay");
				Console.WriteLine("3 - VHS");
				Console.WriteLine("4 - Amazon");
				Console.WriteLine("5 - Google Play");
				Console.WriteLine("6 - iMovie");
				Console.WriteLine("");
				Console.Write("Choose the number of one of the formats: above ");
				try {
				formatNumber = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException e) {
					Console.WriteLine(e);
				}

				switch (formatNumber){
				case 1:
					musicFormat = "DVD";
					break;
				case 2:
					musicFormat = "BluRay";
					break;
				case 3:
					musicFormat = "VHS";
					break;
				case 4:
					musicFormat = "Amazon";
					break;
				case 5:
					musicFormat = "Google Play";
					break;
				case 6:
					musicFormat = "iMovie";
					break;
				default:
					musicFormat = "Other";
					break;
				}
				Format = musicFormat;
			}
	}
}

