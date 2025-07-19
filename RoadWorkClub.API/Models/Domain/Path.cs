﻿namespace RoadWorkClub.API.Models.Domain
{
    public class Path
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double DistanceInKm { get; set; }
        public TimeSpan AvgDuration { get; set; } // this is in minutes
        public DateTime CreatedAt { get; set; }

        public bool IsLoop { get; set; } // does route start & end at same point??
        public TimeSpan RecommendedStartTime { get; set; }

        // navigation properties
        public ICollection<Stopover> Stopovers { get; set; }
        public Difficulty DifficultyRating { get; set; }
    }
}
