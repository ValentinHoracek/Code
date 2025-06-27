using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        private Stack<ICommand> _compensationStack = [];

        public void Execute(ICommand command)
        {
            try
            {
                command.Execute();
                if (command.IsCompensable)
                {
                    _compensationStack.Push(command);
                }

                Console.WriteLine($"LOG: {command} executed successfully.");
            }
            catch
            {
                Console.WriteLine($"LOG: {command} failed.");
            }
        }

        public void Execute(IEnumerable<ICommand> commands)
        {
            foreach (var command in commands)
            {
                Execute(command);
            }
        }

        public void CompensateLast()
        {
            if (_compensationStack.Count > 0)
            {
                _compensationStack.Pop().Compensate();
            }
        }
    }
}
