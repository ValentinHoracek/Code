namespace ChainOfResponsibility
{
    public class VolumeDiscount : DiscountHandler
    {
        public override Order ApplyDiscount(Order order)
        {

            order.UnitPrice *= 0.9m; // 10% discount for for large orders
            return order;
        }

        public override bool CanHandle(Order order)
        {
            return order.Quantity > 10; // Example condition: apply discount if quantity is greater than 10
        }
    }
}
