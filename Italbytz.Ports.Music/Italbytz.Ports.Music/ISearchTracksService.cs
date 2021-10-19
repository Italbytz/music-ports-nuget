using System;
using System.Collections.Generic;
using Italbytz.Ports.Common;

namespace Italbytz.Ports.Music
{
    public interface ISearchTracksService : IService<ISearchTerm, List<ICollectionEntity>>
    {
    }
}
