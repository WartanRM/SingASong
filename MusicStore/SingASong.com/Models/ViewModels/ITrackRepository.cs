namespace SingASong.com.Models.ViewModels
{ 
    public interface ITrackRepository
{
    IEnumerable<Track> GetTracks();
    IEnumerable<Track> GetTrackbyTitle(string _);
    IEnumerable<Track> GetTrackbyAlbum(string _);
    IEnumerable<Track> GetTrackbyArtist(string _);
    IEnumerable<Track> GetTrackbyGenre(string _);
    IEnumerable<Track> GetTrackbyYear(string _);
    Track GetTrack(int _);
    Track AddTrack(Track Track);

    Track UpdateTrack(Track _);
    Track DeleteTrack(int _);

    }
}
