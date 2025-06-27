using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class CommandBase<TReceiver> : ICommand
    {
        public TReceiver? Receiver { get; set; }
        public virtual bool IsCompensable => false;

        public virtual void Compensate()
        {
            Console.WriteLine("Compensation not supported.");
        }

        public virtual void Execute()
        {
            if (Receiver is null)
            {
                throw new InvalidOperationException("Receiver is not set.");
            }
        }
    }
}
