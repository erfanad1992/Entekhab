namespace Entekhab.Domain
{
    public class Mojavez
    {
        public int MojavezId { get; set; }
        public int TrackingCode { get; set; }
        public ICollection<Resid> Resids { get; set; }
    }
}
