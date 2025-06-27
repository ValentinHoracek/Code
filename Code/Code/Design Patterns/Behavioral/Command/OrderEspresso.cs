namespace Command
{
    public class OrderEspresso : CommandBase<CoffeeMachine>
    {
        public override bool IsCompensable => true;
        public override void Execute()
        {
            base.Execute();
            Receiver!.OrderEspresso();
        }
        public override void Compensate()
        {
            Receiver!.CancelEspresso();
        }
        public override string ToString() => "OrderEspresso Command";
    }
}
