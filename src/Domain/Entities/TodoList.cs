using BaseCodeAutoSever.Domain.Common;

namespace BaseCodeAutoSever.Domain.Entities;

public sealed class TodoList : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public string Colour { get; set; } = string.Empty; 
    public ICollection<TodoItem> Items { get; set; } = new List<TodoItem>();
}
