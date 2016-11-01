using System.ComponentModel.DataAnnotations;

namespace GoogleMaps.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string latitude { get; set; }
        public string Longitude { get; set; }
    }
}