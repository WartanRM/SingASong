using System.Diagnostics;

namespace SingASong.com.Models.ViewModels
{
    public class AdminPage
    {
        private List<Track> Tracks;
        public List<User> user { get; set; }

        public Track GetTrack(int Id)
        {
            return Tracks.Where(trck => trck.Id == Id).First();
        }

        public IEnumerable<Track> GetTracks()
        {
            return Tracks;
        }

        public Track DeleteTrack(int id)
        {
            var track = Tracks.Where(t => t.Id == id).FirstOrDefault();
            if (track == null)
                return null;
            Tracks.Remove(track);
            return track;
        }
        public Track UpdateTrack(Track Track)
        {
            var track = Tracks.Where(t => t.Id == Track.Id).FirstOrDefault();
            if (track == null)
                return null;
            Tracks.Remove(track);
            Tracks.Add(Track);
            return Track;
        }
        public Track AddTrack(Track Track)
        {
            if (Track.Id == 0)
            {
                int id = Tracks.Last().Id;
                Track.Id = id + 1;
            }
            Tracks.Add(Track);
            return Track;
        }
        public IEnumerable<User>GetAllUsers()
        {   
            return user;
        }
    }
}
