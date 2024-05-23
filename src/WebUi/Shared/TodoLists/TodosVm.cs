using BaseCodeAutoSever.WebUi.Shared.Common;

namespace BaseCodeAutoSever.WebUi.Shared.TodoLists;

public class TodosVm
{
    public List<LookupDto> PriorityLevels { get; set; } = new();

    public List<TodoListDto> Lists { get; set; } = new();
}
