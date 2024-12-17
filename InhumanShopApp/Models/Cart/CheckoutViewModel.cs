namespace InhumanShopApp.Models.Cart
{
    public class CheckoutViewModel
    {
        public int OrderId { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
    }
}
