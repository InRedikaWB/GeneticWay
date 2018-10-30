﻿using System;
using System.Collections.Generic;

namespace GeneticWay.Core.Models
{
    public class SimReport
    {
        private readonly double _distance;
        public SimReport(FinishStatus finishStatus, double distance, double finalSpeed, int iterationCount,
            List<Coordinate> coordinates, List<Coordinate> forces, ForceField field, List<Zone> zones)
        {
            FinishStatus = finishStatus;
            _distance = Math.Round(distance, Configuration.EpsilonInt);
            FinalSpeed = Math.Round(finalSpeed, Configuration.EpsilonInt - 3);
            IterationCount = iterationCount;
            Coordinates = coordinates;
            Forces = forces;
            Field = field;
            Zones = zones;
        }

        public FinishStatus FinishStatus { get; }
        public double Distance => FinishStatus == FinishStatus.Done ? 0 : _distance;
        public double FinalSpeed { get; }
        public int IterationCount { get; }
        public List<Coordinate> Coordinates { get; }
        public List<Coordinate> Forces { get; }
        public ForceField Field { get; }
        public List<Zone> Zones { get; }

        public override string ToString()
        {
            return $"{FinishStatus.ToString()}|{Distance:F5}|{FinalSpeed:F5}|{IterationCount,8}";
        }
    }
}