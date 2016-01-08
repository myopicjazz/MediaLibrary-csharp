using System;

namespace MediaLibrary
{
	public interface Media
	{
		string Title { get; set; }
		int ReleaseYear { get; set; }
		string Genre { get; set; }
		void SelectGenre ();
		string Format { get; set; }
		void SelectFormat ();
		string KeyPlayer { get; }
		void setKeyPlayer (string firstName);
		void setKeyPlayer(string firstName, string lastName);
		string Series { get; set; }
	}
}

