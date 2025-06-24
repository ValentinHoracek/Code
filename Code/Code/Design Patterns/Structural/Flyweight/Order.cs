namespace Flyweight
{
    public class Order
    {
        public int OrderId { get; }
        private readonly Type _type;

        public Order(int orderId, Type type)
        {
            OrderId = orderId;
            _type = type;
        }

        public void Serve() => _type.Serve(OrderId);
    }
}
