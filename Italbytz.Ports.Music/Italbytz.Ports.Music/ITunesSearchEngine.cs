using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Italbytz.Ports.Common;

namespace Italbytz.Ports.Music
{
    public interface ITunesSearchEngine
    {
        Task<Result<List<ITrackEntity>>> GetSongs(string term);
    }       
}
