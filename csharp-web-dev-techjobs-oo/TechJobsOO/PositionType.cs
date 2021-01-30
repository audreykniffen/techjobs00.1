﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            this.Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
/* Code a ToString() method that just returns the value of a PositionType object.
Use the Generate option again to add the Equals() and GetHashCode() methods. Refer to the final section of the “Classes and Objects, Part 2” chapter if you need a quick review.
Assume that two PositionType objects are equal when their id fields match. */
}
}
