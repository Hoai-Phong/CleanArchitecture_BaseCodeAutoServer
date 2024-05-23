using BaseCodeAutoSever.Application.Common.Services.Data;
using BaseCodeAutoSever.Domain.Enums;
using BaseCodeAutoSever.WebUi.Shared.Common;
using BaseCodeAutoSever.WebUi.Shared.TodoLists;

namespace BaseCodeAutoSever.Application.TodoLists.Queries;

public sealed record GetTodoListsQuery : IRequest<TodosVm>;

public class GetTodoListQueryHandler : IRequestHandler<GetTodoListsQuery, TodosVm>
{
    private readonly IApplicationDbContext _context;

    public GetTodoListQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TodosVm> Handle(GetTodoListsQuery request, 
        CancellationToken cancellationToken)
    {
        return new TodosVm
        {
            PriorityLevels = PriorityLevelExtensions.GetValues()
                .Select(p => new LookupDto { Id = (int)p, Title = p.ToStringFast() })
                .ToList(),
            Lists = await _context.TodoLists
                .ProjectToDto()
                .ToListAsync(cancellationToken)
        };
    }
}
