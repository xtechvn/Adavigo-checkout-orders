namespace ADAVIGO_FRONTEND.Models.Flights.TrackingVoucher
{
    public class B2BTrackingVoucherRequest
    {
        public string voucher_name { get; set; }
        public long user_id { get; set; }
        public string service_id { get; set; }
        public int project_type { get; set; }
        public double total_order_amount_before { get; set; }

    }
}
