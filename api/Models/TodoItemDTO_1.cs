﻿namespace api.Models
{
    public class TodoItemDTO
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsCompleted { get; set; }
        public string? Secret { get; set; }

    }
}
