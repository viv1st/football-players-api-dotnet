using Football_players.Models;

namespace Football_players.Utils
{
    public static class TodoItemExtensions
    {
        public static TodoItemDTO ToDTO(this TodoItem todoItem)
        {
            return new TodoItemDTO { Id = todoItem.Id, Name = todoItem.Name, IsCompleted = todoItem.IsCompleted };
        }

        public static TodoItem ToModel(this TodoItemDTO todoDTO)
        {
            return new TodoItem { Id = todoDTO.Id, Name = todoDTO.Name, IsCompleted = todoDTO.IsCompleted };
        }
    }
}
