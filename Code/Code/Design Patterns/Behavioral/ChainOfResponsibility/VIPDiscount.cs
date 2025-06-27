namespace ChainOfResponsibility
{
    public class VIPDiscount : DiscountHandler
    {
        public override Order ApplyDiscount(Order order)
        {
            order.UnitPrice *= 0.8m; // 20% discount for VIP customers
            return order;
        }
        public override bool CanHandle(Order order)
        {
            return order.IsVip;
        }
    }
}
