using System;
using System.Collections.Generic;

namespace ExplicitArchitecture.TuneSearchExample.Core.Ports
{
    public interface ICollectionEntity
    {
        string Name { get; set; }
        List<ITrackEntity> Tracks { get; set; } 
    }
    
}