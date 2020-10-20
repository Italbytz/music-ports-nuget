using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExplicitArchitecture;

namespace ExplicitArchitecture.TuneSearchExample.Core.Ports
{
    public interface ITunesSearchEngine
    {
        Task<Result<List<TrackEntity>>> GetSongs(string term);
    }       
}
