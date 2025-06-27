namespace ChainOfResponsibility
{
    public record class Order
    {
        public int Quantity { get; set; }
        public bool IsVip { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
