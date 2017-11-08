using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TrackList
    {
        /// <summary>
        /// List of tracks
        /// </summary>
        public List<Track> ListOfTracks = new List<Track>();
        /// <summary>
        /// List of track titles
        /// </summary>
        public List<string> ListOfTrackTitles = new List<string>();
        /// <summary>
        /// Indexer for tracklist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Track this[int index]
        {
            get
            {
                if (index < 0 && index > ListOfTracks.Count - 1)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                else
                {
                    return ListOfTracks[index];
                }
            }
            set
            {
                if (index < 0 && index > ListOfTracks.Count - 1)
                {
                    if (value == null)
                    {
                        throw new NullReferenceException("object is null");
                    }
                }
                else
                {
                    ListOfTracks[index] = value;
                }
            }
        }

        public TrackList()
        {

        }

        public TrackList(Dictionary<string, byte[]> songDictionary)
        {

            foreach (var song in songDictionary)
            {
                Track objTrack = new Track(song);
                ListOfTracks.Add(objTrack);
                ListOfTrackTitles.Add(objTrack.Title);

            }
        }

    }
}