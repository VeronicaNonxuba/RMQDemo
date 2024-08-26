using RMQDemo.Domain.Core.Commands;
using RMQDemo.Domain.Core.Events;

namespace RMQDemo.Domain.Core.Bus;

public interface IEventBus
{
    Task SendCommand<T>(T command) where T : Command;

    void Publish<T>(T @event) where T : Event;

    void Subscriber<T, TH>()
        where T : Event
        where TH : IEventHandler<T>;
}
