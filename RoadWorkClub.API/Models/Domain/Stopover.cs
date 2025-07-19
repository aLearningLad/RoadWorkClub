namespace RoadWorkClub.API.Models.Domain
{
    public class Stopover
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Neighbourhood { get; set; }
        public string Landmarks { get; set; }
        public Guid PathId { get; set; } // ties stopover to a path entry


        // Nav property
        public Path Path { get; set; }

    }
}
