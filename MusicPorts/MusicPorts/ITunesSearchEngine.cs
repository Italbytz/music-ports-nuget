using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommonPorts;

namespace MusicPorts
{
    public interface ITunesSearchEngine
    {
        Task<Result<List<ITrackEntity>>> GetSongs(string term);
    }       
}
