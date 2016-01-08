using System;

namespace MediaLibrary
{
	public class MediaFactory
	{
		public Media get_Media(String mediaType) {
			if (mediaType == null) {
				return null;
			}
			if (mediaType == "BOOK") {
				return new Book();

			} else if (mediaType == "MOVIE") {
				return new Movie();

			} else if (mediaType == "MUSIC") {
				return new Music();
			}

			return null;
		}
	}
}

