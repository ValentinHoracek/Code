namespace Memento
{
    public class DrinkHistory
    {
        private Stack<DrinkConfigSnapshot> _history = new();

        public void Backup(DrinkConfig config) => _history.Push(config.Save());

        public void Undo(DrinkConfig config)
        {
            if (_history.Count > 0)
            {
                var snapshot = _history.Pop();
                config.Restore(snapshot);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }
    }
}
