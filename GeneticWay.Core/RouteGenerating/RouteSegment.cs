﻿namespace GeneticWay.Core.Models
{
    public class RouteSegment
    {
        public RouteSegment(Zone destination, Segment segment, RouteSegmentType type)
        {
            DestinationZone = destination;
            Segment = segment;
            Type = type;
        }

        public Zone DestinationZone { get; }
        public Segment Segment { get; }
        public RouteSegmentType Type { get; }
    }
}