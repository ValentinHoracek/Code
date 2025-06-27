namespace ChainOfResponsibility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Order order1 = new()
            {
                Quantity = 12,
                UnitPrice = 3.0m,
                IsVip = false,
            };
            Order order2 = new()
            {
                Quantity = 8,
                UnitPrice = 5.0m,
                IsVip = true,
            };
            Order order3 = new()
            {
                Quantity = 12,
                UnitPrice = 4.0m,
                IsVip = true,
            };

            List<Order> orders = [order1, order2, order3];

            // Set up chain
            VIPDiscount vip = new();
            VolumeDiscount volume = new();
            NoDiscount none = new();
            vip.SetNext(volume);
            volume.SetNext(none);

            // Start discount chain
            orders.ForEach(order =>
            {
                Console.WriteLine($"Oder: {order}");
                var finalPrice = vip.Handle(order);
                Console.WriteLine($"Final price for order with quantity {order.Quantity}: €{finalPrice:F2}");
            });
        }
    }
}
