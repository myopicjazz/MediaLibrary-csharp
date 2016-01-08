using System;

namespace MediaLibrary
{
	public class Book : Media
	{
		private string _title;
		private int _releaseYear;
		private string _genre;
		private string _format;
		private string _keyPlayer;
		private string _series;

		public Book() {}

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
			Console.WriteLine("7 - Biographies");
			Console.WriteLine("8 - Self Help");
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
				musicGenre = "Biographies";
				break;
			case 8:
				musicGenre = "Self Help";
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
			Console.WriteLine("1 - Hardback");
			Console.WriteLine("2 - Paperback");
			Console.WriteLine("3 - PDF");
			Console.WriteLine("4 - Kindle");
			Console.WriteLine("5 - Nook");
			Console.WriteLine("6 - Audiobook");
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
				musicFormat = "Hardback";
				break;
			case 2:
				musicFormat = "Paperback";
				break;
			case 3:
				musicFormat = "PDF";
				break;
			case 4:
				musicFormat = "Kindle";
				break;
			case 5:
				musicFormat = "Nook";
				break;
			case 6:
				musicFormat = "Audiobook";
				break;
			default:
				musicFormat = "Other";
				break;
			}
			Format = musicFormat;
		}
	}
}



