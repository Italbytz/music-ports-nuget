using System;
using System.Collections.Generic;

namespace ExplicitArchitecture.TuneSearchExample.Core.Ports
{
    public class CollectionEntity
    {
        public String Name { get; set; }
        public List<TrackEntity> Tracks { get; set; } = new List<TrackEntity>();

    }
}
