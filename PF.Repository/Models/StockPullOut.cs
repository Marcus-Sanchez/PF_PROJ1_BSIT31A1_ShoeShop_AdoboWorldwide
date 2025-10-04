using System;

namespace PF.Repository.Models
{
    public enum PullOutStatus { Pending, Approved, Completed, Rejected }

    public class StockPullOut
    {
        public int Id { get; set; }
        public int ShoeColorVariationId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; } = null!;
        public string? ReasonDetails { get; set; }
        public string RequestedBy { get; set; } = null!;
        public string? ApprovedBy { get; set; }
        public DateTime PullOutDate { get; set; } = DateTime.Now;
        public PullOutStatus Status { get; set; } = PullOutStatus.Pending;

        // Navigation
        public ShoeColorVariation ShoeColorVariation { get; set; } = null!;
    }
}
