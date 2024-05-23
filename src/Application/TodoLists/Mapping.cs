using BaseCodeAutoSever.Domain.Entities;
using BaseCodeAutoSever.WebUi.Shared.TodoLists;
using Riok.Mapperly.Abstractions;

namespace BaseCodeAutoSever.Application.TodoLists;

[Mapper]
public static partial class Mapping
{
    public static partial IQueryable<TodoListDto> ProjectToDto(this IQueryable<TodoList> s);
}
