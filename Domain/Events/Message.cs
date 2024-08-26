using System.Net;
using MediatR;

namespace RMQDemo.Domain.Core.Events;

public abstract class Message : IRequest<bool>
{
    public string MessageType { get; protected set; }

    protected Message()
    {
        MessageType = GetType().Name;
    }
}
