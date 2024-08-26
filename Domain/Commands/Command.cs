using RMQDemo.Domain.Core.Events;

namespace RMQDemo.Domain.Core.Commands;

public abstract class Command : Message
{
    public DateTime Timestamp { get; protected set; }
    public Command()
    {
        Timestamp = DateTime.Now;
    }
}
