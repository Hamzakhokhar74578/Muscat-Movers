namespace MuscatMover.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public ICollection<VehicleTiming> VehicleTimings { get; set; }
    }
}
