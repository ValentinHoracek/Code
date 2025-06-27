namespace Command
{
    public class OrderLatte : CommandBase<CoffeeMachine>
    {
        public override bool IsCompensable => true;
        public override void Execute()
        {
            base.Execute();
            Receiver!.OrderLatte();
        }
        public override void Compensate()
        {
            Receiver!.CancelLatte();
        }
        public override string ToString() => "OrderLatte Command";
    }
}
