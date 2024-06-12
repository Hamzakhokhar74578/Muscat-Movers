namespace MuscatMover.Models
{
    public class VehicleTiming
    {
        public int VehicleTimingId { get; set; }
        public int VehicleId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
