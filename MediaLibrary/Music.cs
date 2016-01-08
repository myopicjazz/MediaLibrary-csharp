using System;

namespace MediaLibrary
{
	public class Music : Media
	{
		private string _title;
		private int _releaseYear;
		private string _genre;
		private string _format;
		private string _keyPlayer;
		private string _series;

		public Music() {}

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
			Console.WriteLine("1 - Rock");
			Console.WriteLine("2 - Pop");
			Console.WriteLine("3 - Country");
			Console.WriteLine("4 - Jazz");
			Console.WriteLine("5 - Fusion");
			Console.WriteLine("6 - Christian");
			Console.WriteLine("7 - Reggae");
			Console.WriteLine("8 - Christmas");
			Console.WriteLine("9 - Easy Listening");
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
				musicGenre = "Rock";
				break;
			case 2:
				musicGenre = "Pop";
				break;
			case 32:
				musicGenre = "Country";
				break;
			case 4:
				musicGenre = "Jazz";
				break;
			case 5:
				musicGenre = "Fusion";
				break;
			case 6:
				musicGenre = "Christian";
				break;
			case 7:
				musicGenre = "Reggae";
				break;
			case 8:
				musicGenre = "Christmas";
				break;
			case 9:
				musicGenre = "Easy Listening";
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
			Console.WriteLine("1 - CD");
			Console.WriteLine("2 - Cassette");
			Console.WriteLine("3 - Vinyl");
			Console.WriteLine("4 - MP3");
			Console.WriteLine("5 - Google Play");
			Console.WriteLine("6 - iTunes");
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
				musicFormat = "CD";
				break;
			case 2:
				musicFormat = "Cassette";
				break;
			case 3:
				musicFormat = "Vinyl";
				break;
			case 4:
				musicFormat = "MP3";
				break;
			case 5:
				musicFormat = "Google Play";
				break;
			case 6:
				musicFormat = "iTunes";
				break;
			default:
				musicFormat = "Other";
				break;
			}
			Format = musicFormat;
		}
	}
}