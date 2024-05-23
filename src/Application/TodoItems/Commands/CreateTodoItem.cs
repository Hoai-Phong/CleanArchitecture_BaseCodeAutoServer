using FluentValidation;
using BaseCodeAutoSever.Application.Common.Services.Data;
using BaseCodeAutoSever.Domain.Entities;
using BaseCodeAutoSever.Domain.Events;
using BaseCodeAutoSever.WebUi.Shared.TodoItems;

namespace BaseCodeAutoSever.Application.TodoItems.Commands;

public sealed record CreateTodoItemCommand(CreateTodoItemRequest Item) : IRequest<int>;

public sealed class CreateTodoItemCommandValidator : AbstractValidator<CreateTodoItemCommand>
{
    public CreateTodoItemCommandValidator()
    {
        RuleFor(p => p.Item).SetValidator(new CreateTodoItemRequestValidator());
    }
} 

public sealed class CreateTodoItemCommandHandler
    : IRequestHandler<CreateTodoItemCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateTodoItemCommand request,
        CancellationToken cancellationToken)
    {
        var entity = new TodoItem
        {
            ListId = request.Item.ListId,
            Title = request.Item.Title,
            Done = false
        };

        entity.AddDomainEvent(new TodoItemCreatedEvent(entity));

        _context.TodoItems.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
