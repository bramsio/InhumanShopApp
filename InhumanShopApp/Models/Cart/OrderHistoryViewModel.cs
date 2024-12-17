namespace InhumanShopApp.Models.Cart
{
    public class OrderHistoryViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }

        public List<OrderProductViewModel> Products { get; set; } = new List<OrderProductViewModel>();
    }
}
