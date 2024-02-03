using SingASong.com.Models;
using System.Collections.Generic;

namespace SingASong.com.Repository
{
    public class SongRepository
    {
        public List<Track> _dummyData;

        public SongRepository()
        {
            _dummyData = new List<Track>
            {
            new Track { Id = 1, Title = "Thunderstruck", Artist= "AC/DC", Album= "High Voltage", Year= 1976 },
            new Track { Id = 2, Title = "Bohemian Rhapsody", Artist= "Queen, ", Album= "A Night at the Opera", Year= 1975 },
            new Track { Id = 3, Title = "Imagine", Artist= "John Lennon", Album= "Imagine", Year= 1971 },
            new Track { Id = 4, Title = "Billie Jean", Artist= "Michael Jackson", Album= "Thriller", Year= 1971 },
            new Track { Id = 5, Title = "Sweet Caroline", Artist= "Neil Diamond", Album= "Gold", Year= 1969 },
            new Track { Id = 6, Title = "Dancing Queen", Artist= "ABBA", Album= "Arrival", Year= 1976 },
            new Track { Id = 7, Title = "Mr. Brightside", Artist= "The Killers", Album= "Hot Fuss", Year= 2003 },
            new Track { Id = 8, Title = "Rolling in the Deep", Artist= "Adele", Album= "21", Year= 2011 },
            new Track { Id = 9, Title = "Uptown Funk", Artist= "Mark Ronson ft. Bruno Mars", Album= "UpTown Special", Year= 2014 },
            new Track { Id = 10, Title = "Happy", Artist= "Pharrell Williams", Album= "GIRL", Year= 2014 },
            new Track { Id = 11, Title = "Can't Stop the Feeling!", Artist= "Justin Timberlake", Album= "Trolls", Year= 2016 },
            new Track { Id = 12, Title = "Roar", Artist= "Katy Perry", Album= "Prism", Year= 2013 },
            new Track { Id = 13, Title = "Perfect", Artist= "Ed Sheeran", Album= "Divide", Year= 2017 },
            new Track { Id = 14, Title = "Blank Space", Artist= "Taylor Swift", Album= "1989", Year= 2014 },
            new Track { Id = 15, Title = "Bad Guy", Artist= "Billie Eilish", Album= "WHEN WE ALL FALL ASLEEP, WHERE DO WE GO?", Year= 2019 },
            
        };
        }

        public List<Track> GetAllSongs()
        {
            return _dummyData;
        }

        public Track GetSongById(int id)
        {
            return _dummyData.Find(song => song.Id == id);
        }
    }
}
