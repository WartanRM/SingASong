using System.Diagnostics;

namespace SingASong.com.Models.ViewModels
{
    public class Catalogue
    {
        public Catalogue() { }
        private List<Track> tracks;

        public IEnumerable<Track> GetTrackbyTitle(string title)
        {

            return tracks.Where(s => s.Title.Contains(title)).ToList(); ;

        }

        public IEnumerable<Track> GetTracks()
        {
            return tracks;
        }
        public IEnumerable<Track> GetTrackbyArtist(string artist)
        {

            return tracks.Where(s => s.Artist.Contains(artist)).ToList(); ;

        }

        public IEnumerable<Track> GetTrackbyAlbum(string album)
        {

            return tracks.Where(s => s.Album.Contains(album)).ToList(); ;

        }

        public IEnumerable<Track> GetTrackbyGenre(string genre)
        {

            return tracks.Where(s => s.Genre.Contains(genre)).ToList();

        }

        public IEnumerable<Track> GetTrackbyYear(string year)
        {

            return tracks.Where(s => s.Year.Contains(year)).ToList();

        }
    }
}
