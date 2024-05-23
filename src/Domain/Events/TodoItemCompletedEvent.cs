using BaseCodeAutoSever.Domain.Common;
using BaseCodeAutoSever.Domain.Entities;

namespace BaseCodeAutoSever.Domain.Events;

public sealed class TodoItemCompletedEvent : BaseEvent
{
    public TodoItem Item { get; }

    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }
}
