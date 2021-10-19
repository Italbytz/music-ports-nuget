using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Music
{
    public interface ICollectionEntity
    {
        string Name { get; set; }
        List<ITrackEntity> Tracks { get; set; } 
    }
    
}