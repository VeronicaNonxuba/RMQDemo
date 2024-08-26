using RMQDemo.Domain.Core.Events;

namespace RMQDemo.Domain.Core.Bus;

public interface IEventHandler<in TEvent> : IEventHandler
    where TEvent : Event
{
    Task Handle(TEvent @event);
}

public interface IEventHandler
{

}