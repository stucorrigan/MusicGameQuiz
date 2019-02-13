using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGameQuiz
{
    public class MusicList
    {
        public int AlbumID;
        private string artistName;
        private string trackTitle;
    }

    public void SetAlbum(int albumId, string artist, string track)
    {
        AlbumID = albumId;
        artistName = artist;
        trackTitle = track;

}

    public string GetAlbum()
    {

    }
}
