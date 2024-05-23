using MediatR;
using BaseCodeAutoSever.Application.TodoItems.Commands;
using BaseCodeAutoSever.WebUi.Client.Handlers.Interfaces;
using BaseCodeAutoSever.WebUi.Shared.TodoItems;

namespace BaseCodeAutoSever.WebUi.Client.Handlers.ServerImplementation;

internal class TodoItemsServerHandler :ITodoItemsHandler
{
    private readonly IMediator _mediator;

    public TodoItemsServerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task PutTodoItemAsync(int id, UpdateTodoItemRequest request)
    {
        return _mediator.Send(new UpdateTodoItemCommand(request));
    }

    public Task<int> PostTodoItemAsync(CreateTodoItemRequest request)
    {
        return _mediator.Send(new CreateTodoItemCommand(request));
    }

    public Task DeleteTodoItemAsync(int id)
    {
        return _mediator.Send(new DeleteTodoItemCommand(id));
    }
}
