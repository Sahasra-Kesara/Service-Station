namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        // POCO - Plain Old Class Object
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
