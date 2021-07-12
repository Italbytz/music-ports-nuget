using System;
using System.Collections.Generic;
using CommonPorts;

namespace MusicPorts
{
    public interface ISearchTracksService : IService<ISearchTerm, List<ICollectionEntity>>
    {
    }
}
