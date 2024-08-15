namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CustomerId { get; set; }
    }
}
