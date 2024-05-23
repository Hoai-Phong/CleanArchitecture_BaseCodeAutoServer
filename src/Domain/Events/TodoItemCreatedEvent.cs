using BaseCodeAutoSever.Domain.Common;
using BaseCodeAutoSever.Domain.Entities;

namespace BaseCodeAutoSever.Domain.Events;

public sealed class TodoItemCreatedEvent : BaseEvent
{
    public TodoItem Item { get; }

    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }
}
