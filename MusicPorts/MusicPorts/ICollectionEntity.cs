using System;
using System.Collections.Generic;

namespace MusicPorts
{
    public interface ICollectionEntity
    {
        string Name { get; set; }
        List<ITrackEntity> Tracks { get; set; } 
    }
    
}