using System;
using System.Collections.Generic;
using ExplicitArchitecture;

namespace ExplicitArchitecture.TuneSearchExample.Core.Ports
{
    public interface ISearchTracksService : IService<SearchTracksDTO, List<CollectionEntity>>
    {
    }
}
