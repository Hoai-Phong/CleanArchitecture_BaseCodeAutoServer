using Microsoft.AspNetCore.Mvc;
using BaseCodeAutoSever.Application.TodoLists.Commands;
using BaseCodeAutoSever.Application.TodoLists.Queries;
using BaseCodeAutoSever.WebUi.Shared.Authorization;
using BaseCodeAutoSever.WebUi.Shared.TodoLists;

namespace BaseCodeAutoSever.WebUi.Controllers;

[Authorize(Permissions.Todo)]
public class TodoListsController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<TodosVm>> GetTodoLists()
    {
        return await Mediator.Send(new GetTodoListsQuery());
    }
    [HttpPost]
    public async Task<ActionResult<int>> PostTodoList(
        CreateTodoListRequest request)
    {
        return await Mediator.Send(new CreateTodoListCommand(request));
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> PutTodoList(int id,
        UpdateTodoListRequest request)
    {
        if (id != request.Id) return BadRequest();

        await Mediator.Send(new UpdateTodoListCommand(request));

        return NoContent();
    }   
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> DeleteTodoList(int id)
    {
        await Mediator.Send(new DeleteTodoListCommand(id));

        return NoContent();
    }
}
