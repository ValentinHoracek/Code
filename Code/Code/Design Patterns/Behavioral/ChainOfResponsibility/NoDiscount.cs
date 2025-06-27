namespace ChainOfResponsibility
{
    public class NoDiscount : DiscountHandler
    {
        public override Order ApplyDiscount(Order order)
        {
            // No discount applied, return the order as is
            return order;
        }
        public override bool CanHandle(Order order)
        {
            // This handler does not apply any discount, so it can handle all orders
            return true;
        }
    }
}
