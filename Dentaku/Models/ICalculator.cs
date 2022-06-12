namespace Inabe49.Dentaku.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICalculator
    {
        string Expression { get; }

        void Push(Command command);

        IEnumerable<Command> Allow { get; }
    }
}
