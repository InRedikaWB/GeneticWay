﻿using System;
using System.Linq;
using GeneticWay.Tools;

namespace GeneticWay.Models
{
    public class ForceField
    {
        public Coordinate[,] Field { get; set; }

        public ForceField()
        {
            Field = new Coordinate[Configuration.DegreeCount, Configuration.SectionCount];
        }

        public ForceField(Coordinate[,] field)
        {
            Field = field;
        }

        public ForceField Clone()
        {
            Coordinate[,] storage = new Coordinate[Configuration.DegreeCount, Configuration.SectionCount];
            Array.Copy(Field, storage, Field.Length);
            return new ForceField(storage);
        }
    }
}