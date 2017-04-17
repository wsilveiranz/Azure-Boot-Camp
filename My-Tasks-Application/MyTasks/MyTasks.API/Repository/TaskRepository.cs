using System;
using System.Collections.Generic;
using System.Linq;
using MyTasks.API.Models;

namespace MyTasks.API.Repository
{
    public class TaskRepository
    {
        private readonly List<TaskModel> _items;

        private TaskRepository()
        {
            _items = new List<TaskModel>();
        }

        public void AddTask(TaskModel model)
        {
            _items.Add(model);
        }

        public void CompleteTask(Guid id)
        {
            var find = _items.FirstOrDefault(x => x.Id == id);

            if (find != null)
            {
                find.IsCompleted = true;
            }
        }

        public List<TaskModel> GetTasks()
        {
            return _items;
        }

        private static TaskRepository _instance;
        public static TaskRepository Instance => _instance ?? (_instance = new TaskRepository());
    }
}