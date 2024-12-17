namespace InhumanShopApp.Models.Cart
{
    public class CartViewModel
    {
        public int OrderId { get; set; }

        public List<CartItemViewModel> Items { get; set; } = new List<CartItemViewModel>();
        public decimal TotalPrice { get; set; }

    }
}
